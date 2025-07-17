using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.ReviewComments.queries
{
    public class HideReviewCommand : IRequest<bool>
    {
        public string ReviewId { get; set; }

        public HideReviewCommand(string reviewId)
        {
            ReviewId = reviewId;
        }
    }
}
