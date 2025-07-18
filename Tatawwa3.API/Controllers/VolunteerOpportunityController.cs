﻿using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Enums;



namespace Tatawwa3.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolunteerOpportunityController : ControllerBase
    {

        public IMediator mediator { get; set; }
        public VolunteerOpportunityController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpGet("Get All")]

        public async Task<IActionResult> GetallOpportunites()
        {
            var commands = new GetAllOpportunitiesQuery();
            var res = await mediator.Send(commands);
            return Ok(res);
        }
        [HttpPost("nshr")]
        public async Task<IActionResult> AddOpportunity([FromForm] AddOpportunityDto dto)
        {
            var command = new AddOpportunityGdedCommand { AddOpportunityDto = dto };

            try
            {
                var result = await mediator.Send(command);
                return Ok(new { message = "تمت الإضافة بنجاح"/*, data = result*/ });
            }
            catch (System.Exception ex)
            {
                return StatusCode(500, new { message = ex.Message });
            }
        }

        [HttpGet("Allllocations")]
        public async Task<IActionResult> GetAllLocations()
        {
            var result = await mediator.Send(new GetAllLocationsQuery());
            return Ok(result);
        }


        [HttpGet("bylocation")]

        public async Task<IActionResult> GetOpportunityLocation(string location)
        {

            var query = new GetLocationOpportunitiesQuery(location);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("byCategory")]
        public async Task<IActionResult> GetOpportunityCategory(string CatName)
        {

            var query = new GetCategoryOpportunitiesQuery(CatName);
            var result = await mediator.Send(query);
            return Ok(result);


        }

        [HttpGet("{id}/Detailes")]
        public async Task<IActionResult> GetOpportunityById(string id)
        {
            var query = new GetIdOpportunutyQuery(id);
            var result = await mediator.Send(query);

           

            if (result == null)
                return NotFound(new { message = "❌ الفرصة التطوعية غير موجودة." });

            return Ok(result);
        }


        [HttpGet("updated-databy-id{id}")]
        public async Task<IActionResult> GetUpdatedyById(string id)
        {
            var query = new getdataupdateid(id);
            var result = await mediator.Send(query);



            if (result == null)
                return NotFound(new { message = "❌ الفرصة التطوعية غير موجودة." });

            return Ok(result);
        }



        //[HttpPut("Update{id}")]
        //public async Task<IActionResult> UpdateOpportunity(string id, [FromForm] updateOportunityCommand command)
        //{
        //    if (id != command.updateOportunuityDto.Id)
        //        return BadRequest(new { message = " id doesnt exist." });

        //    var result = await mediator.Send(command);

        //    if (result == null)
        //        return NotFound(new { message = " الفرصة التطوعية غير موجودة." });

        //    return Ok(new
        //    {
        //        message = " تم تحديث الفرصة بنجاح.",
        //        //data = result
        //    });
        //}
        [HttpPut("update/{id}")]
        public async Task<IActionResult> UpdateOpportunity(string id, [FromForm] updateOportunityCommand command)

       

        {
            // لو ID مش في الـDTO، نعينه هنا
            command.updateOportunuityDto.Id = id;

            var result = await mediator.Send(command);

            return Ok(new
            {
                message = result
            });
        }

        [HttpDelete("{id}/remove")]

        public async Task<IActionResult> deleteOpportunity(string id)
        {
            var command = new DeleteOpportunityCommand(id);
            var result = await mediator.Send(command);

            if (result == null)
                return NotFound(new { message = " الفرصة التطوعية غير موجودة." });

            return Ok(new { message = result });
        }



        [HttpPost("nshr forsa")]
        public async Task<IActionResult> AddOpportunity([FromForm] AddOpportunityCommand command)

       
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = await mediator.Send(command);

            if (result == null)
                return BadRequest("باظت و متعملتش");

            return Ok("تم إضافة الفرصة بنجاح");
        }

        [HttpGet("SearchByTitle")]
        public async Task<IActionResult> SearchByTitle([FromQuery] string title)
        {
            var query = new SearchOpportunitiesByTitleQuery(title);
            var result = await mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("forsa-management/by-id")]
        public async Task<IActionResult> GetOpportunitiesByOrgId([FromQuery] string organizationId)
        {
            if (string.IsNullOrEmpty(organizationId))
                return BadRequest(new { message = "يرجى إرسال معرف المنظمة." });

            var result = await mediator.Send(new GetOpportunitiemangmentQuery(organizationId));
            return Ok(result);
        }

        [HttpGet("forsa-management/by-token")]
        
        public async Task<IActionResult> GetOpportunitiesByToken()
        {
            var organizationId = User.FindFirst("OrganizationId")?.Value;

            if (string.IsNullOrEmpty(organizationId))
                return Unauthorized(new { message = "لم يتم التعرف على المنظمة." });

            var result = await mediator.Send(new GetOpportunitiemangmentQuery(organizationId));
            return Ok(result);
        }

        [HttpGet("morag3a-opportunities")]
        public async Task<IActionResult> GetMorag3aOpportunities()
        {
            var result = await mediator.Send(new Morag3aOpportunitiesQuery());
            return Ok(result);
        }
        [HttpPut("approve/{id}")]
        public async Task<IActionResult> ApproveOpportunity(string id)
        {
            var result = await mediator.Send(new UpdateOpportunityStatusCommand(id, OpportunityStatus.Completed));
            return Ok(result);
        }

        [HttpPut("reject/{id}")]
        public async Task<IActionResult> RejectOpportunity(string id)
        {
            var result = await mediator.Send(new UpdateOpportunityStatusCommand(id, OpportunityStatus.Draft));
            return Ok(result);
        }


        [HttpPost("search-by-filters")]
        public async Task<IActionResult> SearchOpportunities([FromBody] OpportunitySearchDto dto)
        {
            var query = new SearchOpportunitiesQuery(dto);
            var result = await mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("count/draft")]
        public async Task<IActionResult> GetDraftCount()
        {
            var result = await mediator.Send(new CountDraftOpportunitiesQuery());
            return Ok(new { count = result });
        }
        [HttpGet("count/completed")]
        public async Task<IActionResult> GetCompletedCount()
        {
            var result = await mediator.Send(new CountCompletedOpportunitiesQuery());
            return Ok(new { count = result });
        }










    }
}
