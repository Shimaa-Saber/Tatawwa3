using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Certificats;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class CertificateService : ICertificateService
    {
        private readonly IGeneric<Participation> _participationRepo;
        private readonly Tatawwa3DbContext _context;

        public CertificateService(IGeneric<Participation> participationRepo,
            Tatawwa3DbContext context
            )
        {
            _participationRepo = participationRepo;
            _context = context;
        }

        public async Task<List<CompletedParticipantDto>> GetCompletedParticipantsAsync(string opportunityId)
        {
            var participants = await _context.Participations
           .Where(p => p.OpportunityId == opportunityId && p.Status == ParticipationStatus.Completed)
            .Include(p => p.Opportunity)
            .ThenInclude(o => o.Organization)
            .Include(p => p.Volunteer)
           .ThenInclude(v => v.User)
              .ToListAsync();

            var result = participants.Select(p => new CompletedParticipantDto
            {
                VolunteerId = p.VolunteerID!,
                FullName = p.Volunteer?.User?.FullName ?? "",
                Email = p.Volunteer?.User?.Email ?? "",
                TotalHours = p.TotalAttendedHours,
                ParticipationDate = p.FirstCheckIn,
               
            }).ToList();

            return result;
        }

        public async Task<bool> IssueCertificateAsync(IssueCertificateDto dto)
        {
            var participation = await _context.Participations
                .Include(p => p.Volunteer)
                .FirstOrDefaultAsync(p => p.Id == dto.ParticipationId && p.Status == ParticipationStatus.Completed);

            if (participation == null)
                return false;

           
            var existing = await _context.Certificates
                .FirstOrDefaultAsync(c => c.ParticipationID == dto.ParticipationId);
            if (existing != null)
                return false;

            var certificate = new Certificate
            {
                Id = Guid.NewGuid().ToString(),
                ParticipationID = dto.ParticipationId,
                VolunteerID = participation.VolunteerID!,
                Title = dto.Title,
                Issuer = dto.Issuer,
                TotalHours = dto.TotalHours,
                IssueDate = DateTime.UtcNow,
                CertificateNumber = $"CERT-{DateTime.UtcNow:yyyyMMddHHmmss}",
                IsVerified = true,
                VerificationCode = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                CreatedAt = DateTime.UtcNow
            };

            _context.Certificates.Add(certificate);
            await _context.SaveChangesAsync();
            return true;
        }


        public async Task<int> IssueGroupCertificatesAsync(IssueGroupCertificatesDto dto)
        {
            var completedParticipants = await _context.Participations
                .Include(p => p.Volunteer)
                .Where(p => p.OpportunityId == dto.OpportunityId && p.Status == ParticipationStatus.Completed)
                .ToListAsync();

            int issuedCount = 0;

            foreach (var participation in completedParticipants)
            {
              
                bool alreadyIssued = await _context.Certificates.AnyAsync(c => c.ParticipationID == participation.Id);
                if (alreadyIssued) continue;

                var cert = new Certificate
                {
                    Id = Guid.NewGuid().ToString(),
                    ParticipationID = participation.Id,
                    VolunteerID = participation.VolunteerID!,
                    Title = dto.Title,
                    Issuer = dto.Issuer,
                    TotalHours = dto.TotalHours,
                    IssueDate = DateTime.UtcNow,
                    CertificateNumber = $"CERT-{DateTime.UtcNow:yyyyMMddHHmmss}-{issuedCount + 1}",
                    IsVerified = true,
                    VerificationCode = Guid.NewGuid().ToString().Substring(0, 8).ToUpper(),
                    CreatedAt = DateTime.UtcNow
                };

                _context.Certificates.Add(cert);
                issuedCount++;
            }

            await _context.SaveChangesAsync();
            return issuedCount;
        }


    }

}
