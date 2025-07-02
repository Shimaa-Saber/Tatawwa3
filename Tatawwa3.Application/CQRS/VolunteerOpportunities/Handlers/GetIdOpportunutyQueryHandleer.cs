using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Application.Services;
using AutoMapper;
using Tatawwa3.Infrastructure.Migrations;
using Tatawwa3.Infrastructure.Repositorirs;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class GetIdOpportunutyQueryHandleer : IRequestHandler<GetIdOpportunutyQuery, DetailsOpportunityDto>
    {
        protected IOpportunity opportunity;
        private readonly IMapper _mapper;
        public GetIdOpportunutyQueryHandleer(IOpportunity opportunity, IMapper mapper)
        {
            this.opportunity = opportunity;
            _mapper = mapper;
        }

        public  Task<DetailsOpportunityDto> Handle(GetIdOpportunutyQuery request, CancellationToken cancellationToken)
        {

            //var opp = opportunity.GetByID(request.Id);

            //if (opp == null)
            //    return Task.FromResult<DetailsOpportunityDto>(null);

            //var dto = _mapper.Map<DetailsOpportunityDto>(opp);

            //return Task.FromResult(dto);
            var entity = opportunity.GetByIdWithIncludes(request.Id);

            if (entity == null)
                return Task.FromResult<DetailsOpportunityDto>(null);

            var dto = _mapper.Map<DetailsOpportunityDto>(entity);

            return Task.FromResult(dto);

        }
    }
}
