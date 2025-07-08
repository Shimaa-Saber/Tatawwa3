using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.MakeApplication.Commands;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.MakeApplication.Handlers
{
    internal class ApplyToOpportunityCommandHandler : IRequestHandler<ApplyToOpportunityCommand, string>
    {
        private readonly IApplicationRepository repository;
        private readonly IMapper mapper;
        private readonly IOpportunity opportunityRepository;
        private readonly IVolunteerProfileRepository volunteerRepo;
        private readonly INotificationService _notificationService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly Tatawwa3DbContext _context;


        public ApplyToOpportunityCommandHandler(
            IApplicationRepository repository,
            IMapper mapper,
            IOpportunity opportunityRepository,
            IVolunteerProfileRepository volunteerRepo,
            INotificationService notificationService,
            IHttpContextAccessor httpContextAccessor,
            Tatawwa3DbContext context)
        {
            this.repository = repository;
            this.mapper = mapper;
            this.opportunityRepository = opportunityRepository;
            this.volunteerRepo = volunteerRepo;
            _notificationService = notificationService;
            _httpContextAccessor = httpContextAccessor;
            _context = context;
        }

        public async Task<string> Handle(ApplyToOpportunityCommand request, CancellationToken cancellationToken)
        {
            var dto = request.addapplication;

            // ✅ Get userId from JWT token
            var userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (string.IsNullOrEmpty(userId))
                return "المستخدم غير مسجل الدخول.";

            string? savedFilePath = null;

            if (dto.Attachment != null && dto.Attachment.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Attachment.FileName);
                var fullPath = Path.Combine(uploadsFolder, fileName);

                using var stream = new FileStream(fullPath, FileMode.Create);
                await dto.Attachment.CopyToAsync(stream, cancellationToken);

                savedFilePath = Path.Combine("uploads", fileName);
            }

            var application = mapper.Map<Tatawwa3.Domain.Entities.Application>(dto);
            application.Id = Guid.NewGuid().ToString();
            application.AttachmentPath = savedFilePath;
            application.ApplicationDate = DateTime.UtcNow;
            application.Status = ApplicationStatus.Pending;
            application.VolunteerID = userId; // ✅ Set VolunteerID from token

            try
            {
                repository.Add(application);
                await repository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("DB Save Failed: " + ex.InnerException?.Message, ex);
            }

            var opportunity = await opportunityRepository.FirstOrDefaultAsync(o => o.Id == dto.OpportunityID);
            if (opportunity != null && opportunity.ApplicationUser != null)
            {
                var preference = await _context.notificationPreferences
                    .FirstOrDefaultAsync(p => p.UserId == opportunity.ApplicationUser.Id);

                if (preference?.NotifyOnNewVolunteerApplication == true)
                {
                    await _notificationService.SendNotificationAsync(
                        userId: opportunity.ApplicationUser.Id,
                        title: "📥 طلب تطوع جديد",
                        message: $"قام متطوع جديد بالتقديم على الفرصة: {opportunity.Title}"

                    );
                }

              
            }
            return "تم التقديم بنجاح ";
        }
    }
}
