using AutoMapper;
using System.Text.Json;
using Tatawwa3.Application.Dtos.AuthDtos;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.API.Mapper.AuthMapper
{
    public class VolunteerRegMapper : Profile
    {
        public VolunteerRegMapper()
        {
            CreateMap<RegisterVolunteerDto, ApplicationUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => ExtractUserName(src.Email)))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(_ => UserType.Volunteer));

            CreateMap<RegisterVolunteerDto, VolunteerProfile>()
                .ForMember(dest => dest.Interests, opt => opt.MapFrom(src => SerializeInterests(src.Interests)))
                .ForMember(dest => dest.TotalHours, opt => opt.MapFrom(_ => 0))
                .ForMember(dest => dest.Rating, opt => opt.MapFrom(_ => 0))
                .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(_ => false));
        }

        private static string SerializeInterests(List<string> interests)
        {
            return JsonSerializer.Serialize(interests);
        }

        private static string ExtractUserName(string email)
        {
            return email.Split('@')[0];
        }
    }
    }

