using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.Services;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    internal class updateOportunityCommandHandler : IRequestHandler<updateOportunityCommand, DetailsOpportunityDto>
    {
        protected IOpportunity opportunity;

        public updateOportunityCommandHandler(IOpportunity opportunity)
        {
            this.opportunity = opportunity;
        }
        public async Task<DetailsOpportunityDto> Handle(updateOportunityCommand request, CancellationToken cancellationToken)
        {
            var opp = opportunity.GetByID(request.updateOportunuityDto.Id);
            if (opp == null)
                return null;

            request.updateOportunuityDto.Map(opp);

            opportunity.UpdateByEntity(opp);
            await opportunity.SaveChangesAsync();

            return opp.Map<DetailsOpportunityDto>();

        }
    }
}
