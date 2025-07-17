using AutoMapper;
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
    public class GetReviewsByOpportunityIdHandler : IRequestHandler<GetReviewsByOpportunityIdQuery, List<showReviewDto>>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IMapper _mapper;

        public GetReviewsByOpportunityIdHandler(IReviewRepository reviewRepository, IMapper mapper)
        {
            _reviewRepository = reviewRepository;
            _mapper = mapper;
        }

        public async Task<List<showReviewDto>> Handle(GetReviewsByOpportunityIdQuery request, CancellationToken cancellationToken)
        {

            //var reviews = await _reviewRepository.GetReviewsWithUserByOpportunityIdAsync(request.OpportunityId);
            //return _mapper.Map<List<showReviewDto>>(reviews);

            var reviews = await _reviewRepository.GetReviewsWithUserByOpportunityIdAsync(request.OpportunityId);

            if (reviews == null || !reviews.Any())
                return new List<showReviewDto>();

            var result = reviews.Select(r => new showReviewDto
            {
                Id = r.Id,
                OpportunityId = r.OpportunityId,
                UserId = r.UserId,
                UserName = r.User?.FullName ?? "زائر", 
                Comment = r.Comment,
                Rating = r.Rating,
                UserProfilePicture = r.User?.VolunteerProfile?.ProfilePictureUrl,
                CreatedAt = r.CreatedAt
            }).ToList();

            return result;
        }
    }
    }

