using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.ReviewComments.commands
{
    public class CreateReviewgdedCommand :IRequest<string>
    {
        public string OpportunityId { get; set; }
        public string UserId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
    }
}
