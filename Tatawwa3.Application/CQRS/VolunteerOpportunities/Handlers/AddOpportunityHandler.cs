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
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using DomainTeam = Tatawwa3.Domain.Entities.Team;


namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class AddOpportunityHandler : IRequestHandler<AddOpportunityCommand, DetailsOpportunityDto>
    {
        private readonly IOpportunity _opportunityRepo;
        private readonly ICategoryRepository _categoryRepo;
        private readonly IOrganizationRepository _organizationRepo;
        private readonly ITeamRepository _teamRepo;

        public AddOpportunityHandler(
            IOpportunity opportunityRepo,
            ICategoryRepository categoryRepo,
            IOrganizationRepository organizationRepo,
            ITeamRepository teamRepo)
        {
            _opportunityRepo = opportunityRepo;
            _categoryRepo = categoryRepo;
            _organizationRepo = organizationRepo;
            _teamRepo = teamRepo;
        }
        public async Task<DetailsOpportunityDto> Handle(AddOpportunityCommand request, CancellationToken cancellationToken)
        {
            var dto = request.AddOpportunityDto;

            
            var category = await _categoryRepo.FirstOrDefaultAsync(c => c.Name == dto.CategoryName);
            if (category == null)
                throw new Exception("الفئه دي كمان مش موجوده");

            
            var organization = await _organizationRepo.FirstOrDefaultAsync(o => o.OrganizationName == dto.OrganizationName);
            if (organization == null)
                throw new Exception("الجهه الي اتكتبت مش موجوده");

            
            DomainTeam? team = null;
            if (!string.IsNullOrWhiteSpace(dto.TeamName))
            {
                team = await _teamRepo.FirstOrDefaultAsync(t => t.Name == dto.TeamName);
                if (team == null)
                {
                    team = new DomainTeam { Name = dto.TeamName };
                    _teamRepo.Add(team);
                    await _teamRepo.SaveChangesAsync();
                }
            }

            
            var opportunity = dto.Map<VolunteerOpportunity>();

            opportunity.CategoryID = category.Id;
            opportunity.OrganizationID = organization.Id;
            opportunity.TeamId = team?.Id;
            opportunity.Status = OpportunityStatus.Published;

            _opportunityRepo.Add(opportunity);
            await _opportunityRepo.SaveChangesAsync();

            return opportunity.Map<DetailsOpportunityDto>();
        }
    }
 }


