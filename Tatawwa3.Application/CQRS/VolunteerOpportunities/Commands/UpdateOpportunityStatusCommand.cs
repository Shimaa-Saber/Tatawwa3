using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands
{
    public class UpdateOpportunityStatusCommand : IRequest<string>
    {
        public string OpportunityId { get; set; }
        public OpportunityStatus Status { get; set; }

        public UpdateOpportunityStatusCommand(string opportunityId, OpportunityStatus status)
        {
            OpportunityId = opportunityId;
            Status = status;
        }
    }

}
