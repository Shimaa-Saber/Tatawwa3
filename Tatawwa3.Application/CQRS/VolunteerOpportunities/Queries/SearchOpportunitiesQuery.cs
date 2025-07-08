using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class SearchOpportunitiesQuery : IRequest<List<OpportunityListDto>>
    {
        public OpportunitySearchDto SearchDto { get; set; }

        public SearchOpportunitiesQuery(OpportunitySearchDto searchDto)
        {
            SearchDto = searchDto;
        }
    }
}
