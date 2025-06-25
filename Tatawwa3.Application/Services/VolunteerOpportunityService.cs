using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
namespace Tatawwa3.Application.Services
{
    public class VolunteerOpportunityService : IVolunteerOpportunityService
    {
        private readonly IOpportunity _repository;
        private readonly IMapper _mapper;

        public VolunteerOpportunityService(IMapper mapper, IOpportunity repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<OpportunityHomeDto>> GetAllOpportunitiesAsync()
        {
            return await _repository
                .GetAllOpportunity()
                .ProjectTo<OpportunityHomeDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}

