
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
            CreateMap<VolunteerOpportunity, searchDto>();

            //CreateMap<VolunteerOpportunity, DetailsOpportunityDto>();
            CreateMap<VolunteerOpportunity, DetailsOpportunityDto>()
         .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
         .ForMember(dest => dest.OrganizationEmail, opt => opt.MapFrom(src => src.Organization.Email))
         .ForMember(dest => dest.OrganizationPhone, opt => opt.MapFrom(src => src.Organization.PhoneNumber))
         .ForMember(dest => dest.OrganizationType, opt => opt.MapFrom(src => src.Organization.OrganizationType.ToString()))
         .ForMember(dest => dest.OrganizationImage, opt => opt.MapFrom(src => src.Organization.ProfileImage))
        
         .ForMember(dest => dest.OrganizationDescription, opt => opt.MapFrom(src => src.Organization.Description))
         .ForMember(dest => dest.VolunteerCount, opt => opt.MapFrom(src => src.Applications.Count))
         .ForMember(dest => dest.RequiredSkills, opt => opt.MapFrom(src => src.RequiredSkills.Select(s => s.Name).ToList()))
         .ForMember(dest => dest.Deadline, opt => opt.MapFrom(src => src.EndDate)); // استخدم EndDate كـ Deadline لو مفيش خاصية مستقلة


        }
    }
}
