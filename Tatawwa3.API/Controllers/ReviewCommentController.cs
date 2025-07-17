using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.API.Mapper.Comments;
using Tatawwa3.Application.CQRS.ReviewComments.commands;
using Tatawwa3.Application.CQRS.ReviewComments.queries;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Dtos.Review;


namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewCommentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IReviewRepository _reviewRepository;


        public ReviewCommentController(IMediator mediator, IReviewRepository reviewRepository)
        {
            _mediator = mediator;
            _reviewRepository = reviewRepository;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateReviewCommand command)
        {
            await _mediator.Send(command);
            return Ok(new { message = "تمت إضافة الكومنت بنجاح" });
        }

        [HttpGet("by-opportunityin detils page/{opportunityId}")]
        public async Task<IActionResult> GetReviewsByOpportunity(string opportunityId)
        {
            var query = new GetReviewsByOpportunityIdQuery(opportunityId);
            var reviews = await _mediator.Send(query);

            if (reviews == null || reviews.Count == 0)
                return NotFound("No reviews found for this opportunity.");

            return Ok(reviews);
        }

        [HttpGet("add-test-review")]
        public async Task<IActionResult> AddTestReview()
        {
            var review = new Review
            {
                Id = Guid.NewGuid().ToString(),
                Comment = "كومنت تجريبي",
                OpportunityId = "3d3cbed4-0412-49c7-86fd-fb9d08682c2b", 
                UserId = "771123c5-605b-4ebf-be43-f0239831db31", // ID بتاع شيماء صابر
                CreatedAt = DateTime.UtcNow
            };

            _reviewRepository.Add(review);
            await _reviewRepository.SaveChangesAsync();

            return Ok("تمت الإضافة");
        }

        [HttpGet("table/{opportunityId}")]
        public async Task<IActionResult> GetReviewsTable(string opportunityId)
        {
            var query = new GetReviewsTableQuery { OpportunityId = opportunityId };
            var result = await _mediator.Send(query);

            if (result == null || result.Count == 0)
                return NotFound("No reviews found for this opportunity.");

            return Ok(result);
        }


        [HttpPost("add-with signalr")]
        public async Task<IActionResult> CreateReview([FromBody] CreateReviewgdedCommand command)
        {
            try
            {
                var result = await _mediator.Send(command);

                if (result == "Review Created")
                    return Ok(new { message = result });

                return BadRequest(new { message = result });
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Failed to add review.", error = ex.Message });
            }
        }
        [HttpDelete("delete/{reviewId}")]
        public async Task<IActionResult> DeleteReview(string reviewId)
        {
            var command = new DeleteReviewCommand(reviewId);
            var result = await _mediator.Send(command);

            if (!result)
                return NotFound("Review not found.");

            return Ok("Review deleted successfully.");
        }

        [HttpGet("reviews/all")]
        public async Task<IActionResult> GetAllReviews()
        {
            var result = await _mediator.Send(new GetAllReviewsTableQuery());
            return Ok(result);
        }

        [HttpGet("review-stats")]
        public async Task<IActionResult> GetReviewStats()
        {
            var result = await _mediator.Send(new GetReviewStatsQuery());
            return Ok(result);
        }
        [HttpGet("search-by-rating")]
        public async Task<IActionResult> SearchByRating([FromQuery] int rating)
        {
            try
            {
                var result = await _mediator.Send(new SearchReviewsByRatingQuery(rating));
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = "Failed to search reviews.", error = ex.Message });
            }
        }
        [HttpPut("hide-review/{id}")]
        public async Task<IActionResult> HideReview(string id)
        {
            var result = await _mediator.Send(new HideReviewCommand(id));
            if (result)
                return Ok(new { message = "Review hidden successfully" });

            return NotFound(new { message = "Review not found" });
        }






    }
}
