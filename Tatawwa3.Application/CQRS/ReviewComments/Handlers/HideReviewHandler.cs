using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.ReviewComments.queries;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.ReviewComments.Handlers
{
    public class HideReviewHandler : IRequestHandler<HideReviewCommand, bool>
    {
        private readonly IReviewRepository _reviewRepository;

        public HideReviewHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<bool> Handle(HideReviewCommand request, CancellationToken cancellationToken)
        {
            var review = _reviewRepository.GetByID(request.ReviewId);
            if (review == null)
                return false;

            review.IsDeleted = true;
            _reviewRepository.UpdateByEntity(review);
            _reviewRepository.SaveChangesAsync();


            return true;
        }
    }
}
