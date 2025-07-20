using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Queries;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Handlers
{
    public class GetActiveVolunteersCountHandler : IRequestHandler<GetActiveVolunteersCountQuery, int>
    {
        private readonly Tatawwa3DbContext _context;

        public GetActiveVolunteersCountHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }


        public async Task<int> Handle(GetActiveVolunteersCountQuery request, CancellationToken cancellationToken)
        {
            return await _context.Participations
                
                .CountAsync();
        }
    
    }
    }
