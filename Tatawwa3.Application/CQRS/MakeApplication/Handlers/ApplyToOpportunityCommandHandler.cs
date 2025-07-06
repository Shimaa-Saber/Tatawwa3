using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.MakeApplication.Commands;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;


namespace Tatawwa3.Application.CQRS.MakeApplication.Handlers
{
    internal class ApplyToOpportunityCommandHandler : IRequestHandler<ApplyToOpportunityCommand, string>
    {
        private readonly IApplicationRepository repository;
        private readonly IMapper mapper;
        private readonly IOpportunity opportunityRepository;
        private readonly IVolunteerProfileRepository volunteerRepo;
        private readonly INotificationService _notificationService;

        public ApplyToOpportunityCommandHandler(IApplicationRepository repository, IMapper mapper,
            IOpportunity opportunityRepository, IVolunteerProfileRepository volunteerRepo, INotificationService notificationService)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.opportunityRepository = opportunityRepository;
            this.volunteerRepo = volunteerRepo;
            _notificationService = notificationService;
        }
        public async Task<string> Handle(ApplyToOpportunityCommand request, CancellationToken cancellationToken)
        {
            var dto = request.addapplication;
            //هناخد البيانات من الفرونت
            string? savedFilePath = null;
            //هنعمل باث نشيل فيه اسم الملف 

           
            if (dto.Attachment != null && dto.Attachment.Length > 0)
            {
                
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                //هنحدد المكان الي هنشيل فيه الفيل ده علي الجهاز بتاعنا
                Directory.CreateDirectory(uploadsFolder); 
                //لو مفيش الفولدر يعمله

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Attachment.FileName);
                //بنعمله اسم عشوائي و نحط هو .pdf kda
                var fullPath = Path.Combine(uploadsFolder, fileName);

                using var stream = new FileStream(fullPath, FileMode.Create);
                await dto.Attachment.CopyToAsync(stream, cancellationToken);
                //كده اتنزل فعلا ع الجهاز

                savedFilePath = Path.Combine("uploads", fileName);

                var application = mapper.Map<Tatawwa3.Domain.Entities.Application>(dto);

                application.Id = Guid.NewGuid().ToString();
                //ده حطيته عشان يعمل id generate تلقائي عشان كان بيجيب null
                application.AttachmentPath = savedFilePath;
                application.ApplicationDate = DateTime.Now;
                application.Status = ApplicationStatus.Pending;

                repository.Add(application);
              await  repository.SaveChangesAsync();

                var opportunity = await opportunityRepository.FirstOrDefaultAsync(o => o.Id == dto.OpportunityID);
                if (opportunity != null && !string.IsNullOrEmpty(opportunity.Organization.Id))
                {
                   
                    //var volunteer = await volunteerRepo.FirstOrDefaultAsync(v => v.Id == dto.);
                    //var volunteerName = volunteer?.User?.FullName ?? "متطوع";

                    await _notificationService.SendNotificationAsync(
                        userId: opportunity.ApplicationUser.Id,
                        title: "📥 طلب تطوع جديد",
                        message: $"قام متطوع جديد بالتقديم على الفرصة: {opportunity.Title}"
                    );
                }



                return "تم التقديم بنجاح ";
            }
            return "لم يتم إرسال ملف. الرجاء إرفاق الملف والمحاولة مرة أخرى ";
        }
    }
}
