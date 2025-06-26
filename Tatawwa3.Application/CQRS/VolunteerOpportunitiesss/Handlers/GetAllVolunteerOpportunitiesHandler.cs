using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Application.ViewModels;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;


namespace Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Handlers
{
    public class GetAllVolunteerOpportunitiesHandler : IRequestHandler<GetAllVolunteerOpportunitiesQuery, List<OpportunityHomeDto>>
    {
        private readonly IVolunteerOpportunityService _opportunityService;

        public GetAllVolunteerOpportunitiesHandler(IVolunteerOpportunityService opportunityService)
        {
            _opportunityService = opportunityService;
        }

        public async Task<List<OpportunityHomeDto>> Handle(GetAllVolunteerOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            return await _opportunityService.GetAllOpportunitiesAsync();
        }
    }
}
