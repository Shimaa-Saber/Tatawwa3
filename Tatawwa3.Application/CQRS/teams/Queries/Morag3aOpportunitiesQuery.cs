using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class Morag3aOpportunitiesQuery: IRequest<List<OpportunityListDto>>
    {
    }
}
