using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.DashBord_Admin.Queries;
using Tatawwa3.Application.Dtos.AdminDashbord;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminDashboardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AdminDashboardController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]

        public async Task<ActionResult<DashboardDto>> GetDashboard()
        {
            var dashboardData = await _mediator.Send(new GetDashboardQuery());
            return Ok(dashboardData);
        }

        [HttpGet("nzra sare3a")]
       
        public async Task<ActionResult<StatisticsDto>> GetStatistics()
        {
            try
            {
                var result = await _mediator.Send(new GetStatisticsQuery());
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "حدث خطأ أثناء تحميل الإحصائيات", error = ex.Message });
            }
        }
    }
}
