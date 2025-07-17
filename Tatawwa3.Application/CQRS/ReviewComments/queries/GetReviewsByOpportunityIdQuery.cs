using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Review;

namespace Tatawwa3.Application.CQRS.ReviewComments.queries
{
    public class GetReviewsByOpportunityIdQuery : IRequest<List<showReviewDto>>
    {
        public string OpportunityId { get; set; }

        public GetReviewsByOpportunityIdQuery(string opportunityId)
        {
            OpportunityId = opportunityId;
        }
    }
}
