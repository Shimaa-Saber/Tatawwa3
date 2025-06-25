using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.MakeApplication.Commands;
using Tatawwa3.Domain.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Enums;
using AutoMapper;


namespace Tatawwa3.Application.CQRS.MakeApplication.Handlers
{
    internal class ApplyToOpportunityCommandHandler : IRequestHandler<ApplyToOpportunityCommand, string>
    {
        private readonly IApplicationRepository repository;
        private readonly IMapper mapper;

        public ApplyToOpportunityCommandHandler(IApplicationRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
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
                repository.SaveChangesAsync();
                //await repository.Add(application);
                //await repository.SaveChangesAsync();


                return "تم التقديم بنجاح ";
            }
            return "لم يتم إرسال ملف. الرجاء إرفاق الملف والمحاولة مرة أخرى ";
        }
    }
}
