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
                .ForMember(dest => dest.UserName, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => UserType.Organization))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));

          
            CreateMap<RegisterOrganizationDto, OrganizationProfile>()
                .ForMember(dest => dest.IsVerified, opt => opt.MapFrom(_ => false));
        }
    }
    
    }

