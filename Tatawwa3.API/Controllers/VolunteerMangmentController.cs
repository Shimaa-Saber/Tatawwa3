﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Tatawwa3.Application.CQRS.VolunteerMangement.Commands;
using Tatawwa3.Application.CQRS.VolunteerMangement.Queries;

namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerMangmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public VolunteerMangmentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("opportunity-applications")]
        public async Task<IActionResult> GetAllApplications(string OppId)
        {
         // var orgUserId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var result = await _mediator.Send(new GetAllApplicationsQuery(OppId));
            return Ok(result);
        }


        [HttpPut("{id}/accept")]
        public async Task<IActionResult> AcceptApplication(string id)
        {
            var result = await _mediator.Send(new AcceptApplicationCommand(id));
            if (!result)
                return NotFound("Application not found.");

            return Ok("Application accepted successfully.");
        }

        [HttpPut("{id}/reject")]
        public async Task<IActionResult> RejectApplication(string id)
        {
            var result = await _mediator.Send(new RejectApplicationCommand(id));
            if (!result)
                return NotFound("Application not found.");

            return Ok("Application rejected successfully.");
        }
        [HttpPut("{id}/note")]
        public async Task<IActionResult> AddNote(string id, [FromBody] string note)
        {
            var result = await _mediator.Send(new AddNoteToApplicationCommand(id, note));
            if (!result)
                return NotFound("Application not found.");

            return Ok("Note added successfully.");
        }

        [HttpGet("profile")]
        public async Task<IActionResult> GetProfile(string userId)
        {
           // var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (string.IsNullOrEmpty(userId))
                return Unauthorized("User ID not found in token.");

            var result = await _mediator.Send(new GetVolunteerProfileQuery(userId));
            return result == null ? NotFound("Profile not found.") : Ok(result);
        }

        [HttpGet("by-name")]
        public async Task<IActionResult> GetApplicationsByName([FromQuery] string name,string opp_id)
        {
            var result = await _mediator.Send(new GetApplicationsByNameQuery(name, opp_id));
            return Ok(result);
        }

        [HttpGet("by-status")]
        public async Task<IActionResult> GetApplicationsByStatus([FromQuery] string status, string opp_id)
        {
            var result = await _mediator.Send(new GetApplicationsByStatusQuery(status, opp_id));
            return Ok(result);
        }

        [HttpGet("by-date")]
        public async Task<IActionResult> GetApplicationsByDate([FromQuery] DateTime date, string opp_id)
        {
            var result = await _mediator.Send(new GetApplicationsByDateQuery(date, opp_id));
            return Ok(result);
        }

        [HttpGet("statistics")]
        public async Task<IActionResult> GetApplicationStatistics(string opp_id)
        {
            var result = await _mediator.Send(new GetApplicationStatisticsQuery(opp_id));
            return Ok(result);
        }


    }
}
