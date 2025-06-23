using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries;
using Tatawwa3.Application.ViewModels;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Repositorirs;


namespace Tatawwa3.Application.CQRS.VolunteerOpportunitiesss.Handlers
{
    public class GetAllVolunteerOpportunitiesHandler:IRequestHandler<GetAllVolunteerOpportunitiesQuery, List<VolunteerOpportunityVM>>
    {
        private readonly IGeneric<VolunteerOpportunity> _repository;
        private readonly IMapper _mapper;
    public GetAllVolunteerOpportunitiesHandler(IGeneric<VolunteerOpportunity> repository,
            IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<VolunteerOpportunityVM>> Handle(GetAllVolunteerOpportunitiesQuery request, CancellationToken cancellationToken)
        {
            var opportunities = await _repository.GetAll()
                .Include(o => o.Category)
                .Include(o => o.Organization)
                .ToListAsync();

            return _mapper.Map<List<VolunteerOpportunityVM>>(opportunities);
        }

    }
}
