using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetOpportunityNamesQuery : IRequest<List<OpportunityNameDto>>
    {
    }
}
