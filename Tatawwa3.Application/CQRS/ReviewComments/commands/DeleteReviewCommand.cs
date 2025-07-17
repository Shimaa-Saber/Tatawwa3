using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.ReviewComments.commands
{
    public class DeleteReviewCommand : IRequest<bool>
    {
        public string ReviewId { get; set; }

        public DeleteReviewCommand(string reviewId)
        {
            ReviewId = reviewId;
        }
    }
}
