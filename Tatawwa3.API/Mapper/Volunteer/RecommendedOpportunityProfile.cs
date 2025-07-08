using AutoMapper;
using System.Text.Json;
using Tatawwa3.Application.Dtos.VolunteerDashboard;
using Tatawwa3.Application.Dtos.VolunteerMangement;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.Volunteer
{
    public class RecommendedOpportunityProfile : Profile
    {
        public RecommendedOpportunityProfile()
        {
            CreateMap<VolunteerOpportunity, RecommendedOpportunityDto>()
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
                .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<VolunteerProfile, VolunteerProfileDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.User.FullName))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User.Email))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.User.City))
                .ForMember(dest=>dest.ProfileImage,opt=>opt.MapFrom(src=>src.ProfilePictureUrl))
                .ForMember(dest => dest.Interests, opt => opt.MapFrom(src => DeserializeInterests(src.Interests)));
        }

        private static string[] DeserializeInterests(string interests)
        {
            return string.IsNullOrEmpty(interests)
                ? new string[0]
                : JsonSerializer.Deserialize<string[]>(interests);
        }
    }
    }


    

