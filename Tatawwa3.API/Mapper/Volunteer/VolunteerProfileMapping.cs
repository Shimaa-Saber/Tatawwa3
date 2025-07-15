using AutoMapper;
using Tatawwa3.Application.Dtos.AdminVolunteer;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.Volunteer
{
    public class VolunteerProfileMapping : Profile
    {
        public VolunteerProfileMapping()
        {
            CreateMap<VolunteerProfile, AdminVolunteerManagementDTO>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src =>
    string.IsNullOrWhiteSpace(src.User.FullName) || src.User.FullName == "string" || src.User.FullName == "0"
        ? "اسم غير متوفر"
        : src.User.FullName
))

                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.ProfilePictureUrl))
                .ForMember(dest => dest.JoinDate, opt => opt.MapFrom(src => src.User.CreatedAt))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.User.City))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
                .ForMember(dest => dest.OpportunitiesAppliedCount, opt => opt.MapFrom(src => src.Participations.Count()))
               .ForMember(dest => dest.TeamsJoinedCount, opt => opt.MapFrom(src => src.TeamsMemberships.Count()))



                .ForMember(dest => dest.VolunteerHours, opt => opt.MapFrom(src => Convert.ToDouble(src.TotalHours)))

                .ForMember(dest => dest.IsBanned, opt => opt.MapFrom(src => src.IsBanned));
        }
    }
}
