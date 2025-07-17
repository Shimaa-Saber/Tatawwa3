using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.ReviewComments.queries;
using Tatawwa3.Application.Dtos.Review;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.ReviewComments.Handlers
{
    public class GetReviewsTableHandler : IRequestHandler<GetReviewsTableQuery, List<ReviewTableDto>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IUserRepository _userRepository;

        public GetReviewsTableHandler(IReviewRepository reviewRepository, IUserRepository userRepository)
        {
            _reviewRepository = reviewRepository;
            _userRepository = userRepository;
        }

        public async Task<List<ReviewTableDto>> Handle(GetReviewsTableQuery request, CancellationToken cancellationToken)
        {
            var reviews = await _reviewRepository.GetReviewsWithUserByOpportunityIdAsync(request.OpportunityId);

            var result = new List<ReviewTableDto>();

            foreach (var review in reviews.OrderByDescending(r => r.CreatedAt))
            {
                var user = await _userRepository.GetByIdAsync(review.UserId);
                result.Add(new ReviewTableDto
                {
                    ReviewId = review.Id,                    // ✅ الجديد
                    OpportunityId = review.OpportunityId,
                    Comment = review.Comment,
                    Rating = review.Rating,
                    CreatedAt = review.CreatedAt,
                    UserName = user?.FullName,
                    UserImage = review.User?.VolunteerProfile?.ProfilePictureUrl,
                    OpportunityName = review.Opportunity?.Title
                });
            }

            return result;
        }
    }

}
