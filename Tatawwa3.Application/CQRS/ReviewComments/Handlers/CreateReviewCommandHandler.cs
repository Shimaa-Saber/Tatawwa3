using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.ReviewComments.commands;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Domain.Entities;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Tatawwa3.Infrastructure.Migrations;


namespace Tatawwa3.Application.CQRS.ReviewComments.Handlers
{
    public class CreateReviewCommandHandler : IRequestHandler<CreateReviewCommand, string>
    {
        private readonly IReviewRepository _reviewRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CreateReviewCommandHandler(IReviewRepository reviewRepository, IHttpContextAccessor httpContextAccessor)
        {
            _reviewRepository = reviewRepository;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> Handle(CreateReviewCommand request, CancellationToken cancellationToken)
        {

            //var user = _httpContextAccessor.HttpContext?.User;
            //var userId = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            //var userName = user.Identity?.Name;

            //var review = new Review
            //{
            //    Id = Guid.NewGuid().ToString(),
            //    OpportunityId = request.OpportunityId,
            //    Comment = request.Comment,
            //    Rating = request.Rating,
            //    CreatedBy = userName,
            //    CreatedAt = DateTime.UtcNow,
            //    UserId = userId
            //};

            // _reviewRepository.Add(review);
            // _reviewRepository.SaveChangesAsync();
            var review = new Review
            {
                Id = Guid.NewGuid().ToString(),
                OpportunityId = request.OpportunityId,
                Comment = request.Comment,
                Rating = request.Rating,
              /*  CreatedBy = "System", */// أو request.CreatedBy لو عايزة تبعتي الاسم كمان
                CreatedAt = DateTime.UtcNow,
                UserId = request.UserId
            };

            _reviewRepository.Add(review);
            await _reviewRepository.SaveChangesAsync(); // مهم جدًا الـ await

            return "تمت إضافة التعليق بنجاح";
        }
    }


}
