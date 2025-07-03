using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.categoriies.Queries;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("names")]
        public async Task<IActionResult> GetCategoryNames()
        {
            var result = await _mediator.Send(new getcategorynameQuery());
            return Ok(result);
        }
    }
}
