using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;

namespace Tatawwa3.Application.CQRS.Team.Handlers
{
    public class CreateTeamCommandHandler:IRequestHandler<CreateTeamCommand, Unit>
    {
        
        private readonly IGeneric<Tatawwa3.Domain.Entities.Team> _teamRepository;
        private readonly IMapper _mapper;

        public CreateTeamCommandHandler(IGeneric<Tatawwa3.Domain.Entities.Team> teamRepository, IMapper mapper)
        {
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateTeamCommand request, CancellationToken cancellationToken)
        {
            var team = _mapper.Map<Tatawwa3.Domain.Entities.Team>(request.Dto);

            team.Status = TeamStatus.Pending;
            team.CreationDate = DateTime.UtcNow;

            team.Id = Guid.NewGuid().ToString();
            _teamRepository.Add(team);
            await _teamRepository.SaveChangesAsync();

            return Unit.Value;
        }


    }
}
