using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunity.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;
using AutoMapper;
using System.Runtime.InteropServices;
using Microsoft.EntityFrameworkCore;


namespace Tatawwa3.Application.CQRS.VolunteerOpportunity.Handlers
{
    internal class GetAllOpportunitiesQueryHandler : IRequestHandler<GetAllOpportunitiesQuery, List<GetAllOpportunitiesDto>>
    {
        protected IOpportunity opportunity;
        protected IMapper mapper;
        public GetAllOpportunitiesQueryHandler(IOpportunity opportunity, IMapper mapper)
        {
            this.opportunity = opportunity;
            this.mapper = mapper;
        }

        public async Task<List<GetAllOpportunitiesDto>> Handle(GetAllOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            var opportunities = await opportunity.GetAll().ToListAsync(); 
            return mapper.Map<List<GetAllOpportunitiesDto>>(opportunities);
        }
    }
}
