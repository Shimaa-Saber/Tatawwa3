﻿using AutoMapper;
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
            CreateMap<CreateTeamDto, Team>();

            CreateMap<UpdateTeamDto, Team>();
            CreateMap<Team, GetTeamaDto>()
            .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name));

            CreateMap<Team, TeamDetailsDto>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName))
                .ForMember(dest => dest.TeamGoals, opt => opt.MapFrom(src => src.TeamGoals));

            CreateMap<TeamMember, MemberDto>()
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Volunteer.User.FullName))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()))
                .ForMember(dest => dest.image, opt => opt.MapFrom(src => src.Volunteer.ProfilePictureUrl));

            CreateMap<VolunteerOpportunity, OpportunityDto>();

          
            CreateMap<JoinRequestDto, JoinRequest>()
                .ForMember(dest => dest.Skills, opt => opt.MapFrom<SkillsResolver>())
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => RequestStatus.Pending.ToString()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(_ => DateTime.UtcNow));


            CreateMap<Team, UpdateTeamPageDto>();
            CreateMap<UpdateTeamPageDto, Team>();

       
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
