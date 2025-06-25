using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands
{
    public class DeleteOpportunityCommand:IRequest<String>
    {
        public string Id { get; set; }

        public DeleteOpportunityCommand(string id)
        {
            Id = id;
        }

    }
}
