

using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Team.Handlers
{
    public class CreateTeamCommandHandler : IRequestHandler<CreateTeamCommand, Unit>
    {
        private readonly IGeneric<Tatawwa3.Domain.Entities.Team> _teamRepository;
        private readonly IGeneric<Category> _categoryRepository;
        private readonly IGeneric<VolunteerOpportunity> _opportunityRepository;
        private readonly IMapper _mapper;

        public CreateTeamCommandHandler(
            IGeneric<Tatawwa3.Domain.Entities.Team> teamRepository,
            IGeneric<Category> categoryRepository,
            IGeneric<VolunteerOpportunity> opportunityRepository,
            IMapper mapper)
        {
            _teamRepository = teamRepository;
            _categoryRepository = categoryRepository;
            _opportunityRepository = opportunityRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var dto = request.Dto;
            var team = _mapper.Map<Tatawwa3.Domain.Entities.Team>(dto);

            team.Status = TeamStatus.Pending;
            team.CreationDate = DateTime.UtcNow;
            team.Id = Guid.NewGuid().ToString();

            // البحث عن الـ Category بالاسم
            if (!string.IsNullOrWhiteSpace(dto.CategoryName))
            {
                var category = await _categoryRepository
                    .FirstOrDefaultAsync(c => c.Name == dto.CategoryName);

                if (category != null)
                    team.CategoryId = category.Id;
            }

            // البحث عن الفرصة بعنوانها
            if (!string.IsNullOrWhiteSpace(dto.OpportunityTitle))
            {
                var opportunity = await _opportunityRepository
                    .FirstOrDefaultAsync(o => o.Title == dto.OpportunityTitle);

                if (opportunity != null)
                    team.OpportunityId = opportunity.Id;
            }

            _teamRepository.Add(team);
            await _teamRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}