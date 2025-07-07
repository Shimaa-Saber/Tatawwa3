
using AutoMapper;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.API.Mapper.Opportunity
{
    public class VolunteerOpportunityProfile:Profile
    {
        public VolunteerOpportunityProfile()

        {
            CreateMap<AddOpportunityDto, VolunteerOpportunity>()
                 .ForMember(dest => dest.Id, opt => opt.Ignore()); 

            CreateMap<VolunteerOpportunity, GetAllOpportunitiesDto>();
            CreateMap<VolunteerOpportunity, searchDto>();
            CreateMap<updateOportunuityDto, VolunteerOpportunity>();
            CreateMap<VolunteerOpportunity, updateOportunuityDto>()
                 .ForMember(dest => dest.Image, opt => opt.Ignore())
                 .ForMember(dest => dest.RequiredSkills,
               opt => opt.MapFrom(src => src.RequiredSkills.Select(s => s.Name).ToList()))
                  .ForMember(dest => dest.OrganizationName,
               opt => opt.MapFrom(src => src.Organization.OrganizationName));
            ;

            CreateMap<VolunteerOpportunity, OpportunityListDto>()
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
           .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

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



            CreateMap<VolunteerOpportunity, VolunteerOpportunityListDto>()
               .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
               .ForMember(dest => dest.ApplicantsCount, opt => opt.MapFrom(src => src.Applications.Count))
               .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Reviews.Any() ? src.Reviews.Average(r => r.Rating) : 0))
               .ForMember(dest => dest.StatusDisplay, opt => opt.MapFrom(src =>
                   src.Status == Domain.Enums.OpportunityStatus.Published ? "نشطة" :
                   src.Status == Domain.Enums.OpportunityStatus.Draft ? "قيد المراجعة" :
                   src.Status == Domain.Enums.OpportunityStatus.Completed ? "مكتملة" : "غير معروف"));


        }
    }
}
