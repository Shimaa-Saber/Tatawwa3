using AutoMapper;
using Tatawwa3.Application.Dtos.VolunteerDashboard;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.Volunteer
{
    public class RecommendedOpportunityProfile:Profile
    {
        public RecommendedOpportunityProfile()
        {
            CreateMap<VolunteerOpportunity, RecommendedOpportunityDto>()
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name)) ;
        }
    }
}
