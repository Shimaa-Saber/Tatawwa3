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
     .ForMember(dest => dest.OpportunityTitle, opt => opt.MapFrom(src => src.Title))
     .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
     .ForMember(dest => dest.Category, opt => opt.MapFrom(src => src.Category.Name))
     .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
     .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.Id))
     .ForMember(dest => dest.Location, opt => opt.MapFrom(src => src.Location))
     .ForMember(dest => dest.Image, opt => opt.MapFrom(src => src.Image));

        }

        private static string[] DeserializeInterests(string interests)
        {
            return string.IsNullOrEmpty(interests)
                ? new string[0]
                : JsonSerializer.Deserialize<string[]>(interests);
        }
    }
    }


    

