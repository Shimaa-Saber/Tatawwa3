using MediatR;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.ReviewComments.commands;
using Tatawwa3.Application.Hubs;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Domain.Entities;


namespace Tatawwa3.Application.CQRS.ReviewComments.Handlers
{
    public class CreateReviewWithSignalRCommandHandler : IRequestHandler<CreateReviewgdedCommand, string>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IHubContext<ReviewHub> _hubContext;

        public CreateReviewWithSignalRCommandHandler(IReviewRepository reviewRepository, IHubContext<ReviewHub> hubContext)
        {
            _reviewRepository = reviewRepository;
            _hubContext = hubContext;
        }

        public async Task<string> Handle(CreateReviewgdedCommand request, CancellationToken cancellationToken)
        {
            var review = new Review
            {
                Id = Guid.NewGuid().ToString(),
                Comment = request.Comment,
                OpportunityId = request.OpportunityId,
                UserId = request.UserId,
                CreatedAt = DateTime.UtcNow,
                Rating = request.Rating
            };

            _reviewRepository.Add(review);
            var result = await _reviewRepository.SaveChangesAsync();

            if (result > 0)
            {
                // Send SignalR message to group
                await _hubContext.Clients.Group(request.OpportunityId)
                    .SendAsync("ReceiveReview", new
                    {
                        Comment = review.Comment,
                        UserId = review.UserId,
                        CreatedAt = review.CreatedAt
                    });

                return "Review Created";
            }

            return "Review بشهمي";
        }
    }

}
