using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands
{
   public class updateOportunityCommand:IRequest<DetailsOpportunityDto>
    {
       public updateOportunuityDto updateOportunuityDto { get; set; }
    }
}
