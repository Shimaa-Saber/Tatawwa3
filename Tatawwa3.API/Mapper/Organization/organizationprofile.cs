using AutoMapper;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.Organization
{
    public class organizationprofile:Profile
    {
        public organizationprofile()
        {

            //CreateMap<OrganizationProfile, OrganizationbasedFilterationDTO>()
            //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.OrganizationName))
            //.ForMember(dest => dest.ProfileImage, opt => opt.MapFrom(src => src.ProfileImage)) // أو ProfilePictureUrl لو بتستخدميها
            //.ForMember(dest => dest.OrganizationType, opt => opt.MapFrom(src => src.OrganizationType.ToString()))
            //.ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            //.ForMember(dest => dest.OpportunitiesCount, opt => opt.MapFrom(src => src.VolunteerOpportunities.Count));


            CreateMap<OrganizationProfile, OrganizationbasedFilterationDTO>()
    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.OrganizationName))
    .ForMember(dest => dest.ProfileImage, opt => opt.MapFrom(src => src.ProfilePictureUrl))
    .ForMember(dest => dest.OrganizationType, opt => opt.MapFrom(src => src.OrganizationType.ToString()))
    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
    .ForMember(dest => dest.IsBanned,
           opt => opt.MapFrom(src => src.IsBanned))
    .ForMember(dest => dest.OpportunitiesCount, opt => opt.MapFrom(src =>
        src.VolunteerOpportunities != null
        ? src.VolunteerOpportunities.Count(vo => vo.OrganizationID == src.Id)
        : 0))
    .ForMember(dest => dest.TeamsCount, opt => opt.MapFrom(src =>
        src.Teams != null
        ? src.Teams.Count(t => t.OrganizationID == src.Id)
        : 0));


            CreateMap<UpdateOrganizationDto, OrganizationProfile>()
          .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));
            CreateMap<OrganizationProfile, UpdateOrganizationDto>().ReverseMap();




        }
    }
}
