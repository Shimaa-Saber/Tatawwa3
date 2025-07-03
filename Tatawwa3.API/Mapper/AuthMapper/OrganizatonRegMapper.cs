using AutoMapper;
using Tatawwa3.Application.Dtos.AuthDtos;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.API.Mapper.AuthMapper
{
    public class OrganizatonRegMapper: Profile
    {
        public OrganizatonRegMapper()
        {
            CreateMap<RegisterOrganizationDto, ApplicationUser>()
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => ExtractUserName(src.Email)))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => UserType.Organization))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow))
                .ForMember(dest=>dest.FullName, opt => opt.MapFrom(src => src.OrganizationName));



            CreateMap<RegisterOrganizationDto, OrganizationProfile>()
                .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(_ => false));
        }

        private static string ExtractUserName(string email)
        {
            return email.Split('@')[0];
        }
    }
    
    }

