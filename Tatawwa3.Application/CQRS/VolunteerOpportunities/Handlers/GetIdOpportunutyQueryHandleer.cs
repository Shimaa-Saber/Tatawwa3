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

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class GetIdOpportunutyQueryHandleer : IRequestHandler<GetIdOpportunutyQuery, DetailsOpportunityDto>
    {
        protected IOpportunity opportunity;
         public GetIdOpportunutyQueryHandleer(IOpportunity opportunity)
        {
            this.opportunity = opportunity;
        }

        public  Task<DetailsOpportunityDto> Handle(GetIdOpportunutyQuery request, CancellationToken cancellationToken)
        {
            var opp =  opportunity.GetByID(request.Id);

            if (opp == null)
                return Task.FromResult<DetailsOpportunityDto>(null);

            var dto = opp.Map<DetailsOpportunityDto>();

            return Task.FromResult(dto);

        }
    }
}
