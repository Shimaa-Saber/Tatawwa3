using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using DomainTeam = Tatawwa3.Domain.Entities.Team;


namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class updateOportunityCommandHandler : IRequestHandler<updateOportunityCommand, string>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IOrganizationRepository _organizationRepo;
        private readonly ITeamRepository _teamRepo;
        private readonly ISkillReprosatry _skillRepo;

        public updateOportunityCommandHandler(
            IOpportunity opportunityRepo,
            ICategoryRepository categoryRepo,
            IOrganizationRepository organizationRepo,
            ITeamRepository teamRepo,
            ISkillReprosatry skillRepo)
        {
            _opportunityRepo = opportunityRepo;
            _categoryRepo = categoryRepo;
            _organizationRepo = organizationRepo;
            _teamRepo = teamRepo;
            _skillRepo = skillRepo;
        }
        public async Task<string> Handle(updateOportunityCommand request, CancellationToken cancellationToken)
        {
            var dto = request.updateOportunuityDto;
            //var opportunity =  _opportunityRepo.GetByID(dto.Id)
            var opportunity = _opportunityRepo.GetByIdForUpdate(dto.Id)
             ?? throw new Exception("الفرصة غير موجودة");

            if (!string.IsNullOrEmpty(dto.Title)) opportunity.Title = dto.Title;
            if (!string.IsNullOrEmpty(dto.Description)) opportunity.Description = dto.Description;
            if (!string.IsNullOrEmpty(dto.Location)) opportunity.Location = dto.Location;
            if (dto.StartDate.HasValue) opportunity.StartDate = dto.StartDate.Value;
            if (dto.EndDate.HasValue) opportunity.EndDate = dto.EndDate.Value;
            if (dto.RequiredVolunteers.HasValue) opportunity.RequiredVolunteers = dto.RequiredVolunteers.Value;
            if (dto.TimeAttend != null) opportunity.Conditions = dto.TimeAttend;
            if (dto.IsAttendanceTracked.HasValue) opportunity.IsAttendanceTracked = dto.IsAttendanceTracked;
            if (dto.IsCertificateAvailable.HasValue) opportunity.IsCertificateAvailable = dto.IsCertificateAvailable;
            if (dto.TotalHours.HasValue) opportunity.TotalHours = dto.TotalHours;
            if (dto.GenderRequirement.HasValue) opportunity.GenderRequirement = dto.GenderRequirement;

            if (dto.Image != null && dto.Image.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);
                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.Image.FileName);
                var fullPath = Path.Combine(uploadsFolder, fileName);
                using var stream = new FileStream(fullPath, FileMode.Create);
                await dto.Image.CopyToAsync(stream, cancellationToken);
                opportunity.Image = Path.Combine("uploads", fileName);
            }

            if (!string.IsNullOrWhiteSpace(dto.CategoryName))
            {
                var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName)
                    ?? throw new Exception("الفئة غير موجودة");
                opportunity.CategoryID = category.Id;
            }

            if (!string.IsNullOrWhiteSpace(dto.OrganizationName))
            {
                var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName)
                    ?? throw new Exception("الجهة غير موجودة");
                opportunity.OrganizationID = organization.Id;
            }

            if (!string.IsNullOrWhiteSpace(dto.TeamName))
            {
                var team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
                if (team == null)
                {
                    team = new DomainTeam { Name = dto.TeamName };
                    _teamRepo.Add(team);
                    await _teamRepo.SaveChangesAsync();
                }
                opportunity.TeamId = team.Id;
            }


            if (dto.RequiredSkills != null && dto.RequiredSkills.Any())
            {
                var existingSkills = opportunity.RequiredSkills?.Select(s => s.Name).ToList() ?? new List<string>();
                var newSkills = dto.RequiredSkills.Except(existingSkills).ToList();

                foreach (var skillName in newSkills)
                {
                    var skill = new Skilless
                    {
                        Id = Guid.NewGuid().ToString(),
                        Name = skillName,
                        OpportunityID = opportunity.Id
                    };
                    _skillRepo.Add(skill);
                }

                await _skillRepo.SaveChangesAsync();
            }

            _opportunityRepo.UpdateByEntity(opportunity);


            await _opportunityRepo.SaveChangesAsync();
            return "تم تحديث الفرصة بنجاح";

        }
    }
}
