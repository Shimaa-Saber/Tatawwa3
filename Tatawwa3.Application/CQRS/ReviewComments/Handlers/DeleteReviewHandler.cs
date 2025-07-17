using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.ReviewComments.commands;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Migrations;

namespace Tatawwa3.Application.CQRS.ReviewComments.Handlers
{
    public class DeleteReviewHandler : IRequestHandler<DeleteReviewCommand, bool>
    {
        private readonly IReviewRepository _reviewRepository;

        public DeleteReviewHandler(IReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        public async Task<bool> Handle(DeleteReviewCommand request, CancellationToken cancellationToken)
        {
            var review = _reviewRepository.GetByID(request.ReviewId);
            if (review == null)
                return false;

             _reviewRepository.Remove(request.ReviewId);
            await _reviewRepository.SaveChangesAsync();
            return true;
        }
    }
}
