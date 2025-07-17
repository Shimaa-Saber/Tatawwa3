using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Review;

namespace Tatawwa3.Application.CQRS.ReviewComments.commands
{
    public class GetAllReviewsTableQuery : IRequest<List<ReviewTableDto>>
    {
    }
}
