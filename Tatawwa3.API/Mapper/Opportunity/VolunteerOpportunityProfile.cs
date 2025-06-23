
using AutoMapper;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.API.Mapper.Opportunity
{
    public class VolunteerOpportunityProfile:Profile
    {
        public VolunteerOpportunityProfile()
        {
            CreateMap<VolunteerOpportunity, GetAllOpportunitiesDto>();
        }
    }
}
