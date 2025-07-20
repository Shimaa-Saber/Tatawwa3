using MediatR;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.ReviewComments.commands;
using Tatawwa3.Application.Hubs;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;


namespace Tatawwa3.Application.CQRS.ReviewComments.Handlers
{
    public class CreateReviewWithSignalRCommandHandler : IRequestHandler<CreateReviewgdedCommand, string>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IHubContext<ReviewHub> _hubContext;
        private readonly IVolunteerOpportunityRepository _opportunityRepository;
        private readonly IVolunteerProfileRepository _volunteerRepo;
        private readonly INotificationService _notificationService;

        public CreateReviewWithSignalRCommandHandler(IReviewRepository reviewRepository, IHubContext<ReviewHub> hubContext,
            IVolunteerOpportunityRepository opportunityRepository,
            IVolunteerProfileRepository volunteerRepo, INotificationService notificationService
            )
        {
            _reviewRepository = reviewRepository;
            _hubContext = hubContext;
            _opportunityRepository = opportunityRepository;
            _volunteerRepo = volunteerRepo;
            _notificationService = notificationService;
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
               
                await _hubContext.Clients.Group(request.OpportunityId)
                    .SendAsync("ReceiveReview", new
                    {
                        Comment = review.Comment,
                        UserId = review.UserId,
                        CreatedAt = review.CreatedAt
                    });

                var opportunity = await _opportunityRepository
               .GetQueryable()
              .Include(o => o.Organization)
                .ThenInclude(org => org.User)
            .FirstOrDefaultAsync(o => o.Id == request.OpportunityId);

                if (opportunity?.Organization?.User != null)
                {
                    string message = $"تم إضافة تعليق جديد على الفرصة: {opportunity.Title}";

                    await _notificationService.SendNotificationAsync(
                        userId: opportunity.Organization.User.Id,
                        title: "💬 تعليق جديد",
                        message: message
                    );
                }


                return "Review Created";
            }

          


            return "Review بشهمي";
        }
    }

}
