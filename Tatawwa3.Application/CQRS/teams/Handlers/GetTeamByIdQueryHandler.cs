using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetTeamByIdQueryHandler : IRequestHandler<GetTeamByIdQuery, UpdateTeamPageDto>
    {
        private readonly Tatawwa3DbContext _context;
        private readonly IMapper _mapper;

        public GetTeamByIdQueryHandler(Tatawwa3DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UpdateTeamPageDto> Handle(GetTeamByIdQuery request, CancellationToken cancellationToken)
        {
            var team = await _context.Teams
                .Include(t => t.Category)
                .Include(t => t.Opportunities)
                .FirstOrDefaultAsync(t => t.Id == request.Id);

            if (team == null)
                throw new KeyNotFoundException("Team not found");

            return _mapper.Map<UpdateTeamPageDto>(team);
        }
    }
}
