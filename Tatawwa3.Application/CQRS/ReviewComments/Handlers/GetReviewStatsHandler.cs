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
    public class GetReviewStatsHandler : IRequestHandler<GetReviewStatsQuery, ReviewStatsDto>
    {
        private readonly IReviewRepository _repository;

        public GetReviewStatsHandler(IReviewRepository repository)
        {
            _repository = repository;
        }

        public async Task<ReviewStatsDto> Handle(GetReviewStatsQuery request, CancellationToken cancellationToken)
        {
            var allReviews =  _repository.GetAll(); // Assuming it returns IQueryable or List

            var totalReviews = allReviews.Count(r => !r.IsDeleted);
            var averageRating = allReviews.Where(r => !r.IsDeleted).Any()
                ? allReviews.Where(r => !r.IsDeleted).Average(r => r.Rating)
                : 0;
            var deletedReviews = await _repository.CountDeletedReviewsAsync(); /*allReviews.Count(r => r.IsDeleted);*/

            return new ReviewStatsDto
            {
                TotalReviews = totalReviews,
                AverageRating = Math.Round(averageRating, 2),
                DeletedReviews = deletedReviews
            };
        }
    }

}
