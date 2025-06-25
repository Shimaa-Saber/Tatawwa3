using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.MappingProfiles
{
    public class TeamProfile : Profile
    {
        public TeamProfile()
        {
            CreateMap<Team, GetTeamaDto>();

            CreateMap<Team, TeamDetailsDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName));

            CreateMap<TeamMember, MemberDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Volunteer.User.UserName))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));

            CreateMap<VolunteerOpportunity, OpportunityDto>();

          
            CreateMap<JoinRequestDto, JoinRequest>()
                .ForMember(dest => dest.Skills, opt => opt.MapFrom<SkillsResolver>())
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => RequestStatus.Pending))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));
        }
    }

   
    public class SkillsResolver : IValueResolver<JoinRequestDto, JoinRequest, string>
    {
        public string Resolve(JoinRequestDto source, JoinRequest destination, string destMember, ResolutionContext context)
        {
            return JsonSerializer.Serialize(source.Skills);
        }
    }
}
