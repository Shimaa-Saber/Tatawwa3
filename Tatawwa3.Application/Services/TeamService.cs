﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly IGeneric<Team> _teamRepo;
        private readonly IGeneric<JoinRequest> _joinRequestRepo;
        private readonly Tatawwa3DbContext _tatawwa3DbContext;
        private readonly ITeamRepository _teamRepository;
        private readonly IMapper _mapper;
        private readonly IGeneric<VolunteerProfile> _volunteerRepo;
        private readonly INotificationService _notificationService;

        public TeamService(
            IGeneric<Team> teamRepo,
            IGeneric<JoinRequest> joinRequestRepo,
            Tatawwa3DbContext tatawwa3DbContext,
            ITeamRepository teamRepository,
            IMapper mapper,
            IGeneric<VolunteerProfile> volunteerRepo,
            INotificationService notificationService


        )
        {
            _teamRepo = teamRepo;
            _joinRequestRepo = joinRequestRepo;
            _tatawwa3DbContext = tatawwa3DbContext;
            _teamRepository = teamRepository;
            _mapper = mapper;
            _volunteerRepo = volunteerRepo;
            _notificationService = notificationService;
        }

        public async Task<List<GetTeamaDto>> GetAllTeamsAsync()
        {
            var teams = await _tatawwa3DbContext.Teams
                .Include(t => t.Category)
                .Include(t => t.Organization)
                .Select(team => new GetTeamaDto
                {
                    Id = team.Id,
                    Name = team.Name,
                    Description = team.Description,
                    City = team.City,
                    CategoryName = team.Category != null ? team.Category.Name : null,
                    OrganizationName = team.Organization != null ? team.Organization.OrganizationName : null,
                    CurrentMembersCount = _tatawwa3DbContext.JoinRequests
                        .Count(j => j.TeamId == team.Id
                                    && j.Status == RequestStatus.Accepted
                                    && !j.IsDeleted)
                })
                .ToListAsync();

            return teams;
        }




        //public async Task<List<GetTeamaDto>> GetAllTeamsAsync()
        //{
        //    var teams = await _tatawwa3DbContext.Teams
        //        .Select(team => new GetTeamaDto
        //        {
        //            Id = team.Id,
        //            Name = team.Name,
        //            MaxNumberOfVolunteers = team.MaxNumberOfVolunteers,

        //            // عدد الأعضاء الفعليين (طلبات انضمام مقبولة)
        //            CurrentMembersCount = _tatawwa3DbContext.JoinRequests
        //                .Count(jr => jr.TeamId == team.Id && jr.Status == RequestStatus.Accepted)
        //        })
        //        .ToListAsync();

        //    return teams;
        //}

        public async Task<TeamDetailsDto> GetTeamDetailsAsync(string teamId)
        {

            var team = await _tatawwa3DbContext.Teams
           .Include(t => t.Category)
           .Include(t => t.Organization)
           .Include(t => t.Members)
           .ThenInclude(m => m.Volunteer)
               .ThenInclude(v => v.User)
       .Include(t => t.Opportunities)
       .FirstOrDefaultAsync(t => t.Id == teamId);

            if (team == null)
            {
                return null;
            }
             

            var dto = team.Map<TeamDetailsDto>();
            dto.TotalMembers = team.Members?.Count ?? 0;
            dto.AvailableOpportunities = team.Opportunities?.Count(o => o.Status == OpportunityStatus.Published) ?? 0;
            dto.TotalProjects = 8;
            dto.CompletionRate = 95;

            return dto;
        }

        public async Task<List<GetTeamaDto>> GetTeamsByCityAsync(string city)
        {
            var teams = _teamRepository.GetAllTeams()
        .Where(t => t.City == city)
        .ProjectTo<GetTeamaDto>(_mapper.ConfigurationProvider);

            return await teams.ToListAsync();
        }

        public async Task SendJoinRequestAsync(JoinRequestDto dto, string volunteerId)
        {
            var newRequest = dto.Map<JoinRequest>();
            newRequest.Id = Guid.NewGuid().ToString();
            newRequest.VolunteerId = volunteerId;

            _joinRequestRepo.Add(newRequest);
            await _joinRequestRepo.SaveChangesAsync();

            var team = await _teamRepo
           .GetQueryable()
            .Include(t => t.Organization)
            .ThenInclude(o => o.User)
           .FirstOrDefaultAsync(t => t.Id == dto.TeamId);



            if (team != null && team.Organization?.User != null)
            {
                var volunteer = await _volunteerRepo.FirstOrDefaultAsync(v => v.Id == volunteerId);
                var volunteerName = volunteer?.User?.FullName ?? "متطوع";

                string message = $"قام {volunteerName} بطلب الانضمام إلى الفريق: {team.Name}";

                await _notificationService.SendNotificationAsync(
                    
                    userId: team.Organization.User.Id,
                    title: "📥 طلب انضمام الى فريق",
                    message: message,
                    joinRecuestId: newRequest.Id

                );
            }
        }
        public async Task<List<GetTeamaDto>> GetTeamsByNameAsync(string name)
        {
            var query = _teamRepository.GetAllTeams()
                .Where(t => t.Name.Contains(name))
                .ProjectTo<GetTeamaDto>(_mapper.ConfigurationProvider);

            return await query.ToListAsync();
        }
        public async Task<List<GetTeamaDto>> GetTeamsByCategoryAsync(string categoryName)
        {
            var teams = _teamRepository.GetAllTeams()
                .Where(t => t.Category != null && t.Category.Name == categoryName)
                .ProjectTo<GetTeamaDto>(_mapper.ConfigurationProvider);

            return await teams.ToListAsync();
        }

        public async Task DEleteVolunteerTeamAsync(string Teamid)
        {
            var opportunities = _tatawwa3DbContext.VolunteerOpportunities.Where(O => O.TeamId == Teamid);
            _tatawwa3DbContext.VolunteerOpportunities.RemoveRange(opportunities);


         
            var members = _tatawwa3DbContext.TeamMembers
                .Where(m => m.TeamID == Teamid);
            _tatawwa3DbContext.TeamMembers.RemoveRange(members);


            var team = await GetTeamByIdAsync(Teamid);
            _tatawwa3DbContext.Teams.Remove(team);

            await _tatawwa3DbContext.SaveChangesAsync();
        }

        public async Task UpdateTeamAsync(UpdateTeamDto updateTeam, string teamId)
        {
            var team = await GetTeamByIdAsync(teamId);
            _mapper.Map<UpdateTeamDto>(team);

            _teamRepo.UpdateByEntity(team);

        }

        public async Task<Team> GetTeamByIdAsync(string teamId)
        {
            var team = await _tatawwa3DbContext.Teams.FindAsync(teamId);

            if (team == null)
                throw new Exception("Team not found");

            return team;
        }

        //////So
        ///

        public async Task<string> RespondToJoinRequestAsync(string teamId, string volunteerId, bool isAccepted)
        {
            var team = await _tatawwa3DbContext.Teams.FindAsync(teamId);
            if (team == null)
                throw new Exception("تيم مش موجود");

            var joinRequest = await _tatawwa3DbContext.JoinRequests
                .FirstOrDefaultAsync(j => j.TeamId == teamId && j.VolunteerId == volunteerId);

            if (joinRequest == null)
                throw new Exception("Join request not found");

            var status = isAccepted ? TeamMemberStatus.Accepted : TeamMemberStatus.Rejected;
            joinRequest.Status = (RequestStatus)(int)status;


            if (isAccepted)
            {
                // Add to team members
                var teamMember = new TeamMember
                {
                    Id = Guid.NewGuid().ToString(),
                    TeamID = teamId,
                    VolunteerID = volunteerId,
                    Status = TeamMemberStatus.Accepted
                };

                await _tatawwa3DbContext.TeamMembers.AddAsync(teamMember);
            }

            await _tatawwa3DbContext.SaveChangesAsync();
            return isAccepted ? "تم قبول المتطوع في الفريق" : "تم رفض الطلب";
        }

        public async Task<string> RespondToJoinRequesgdedtByIdAsync(string joinRequestId, bool isAccepted)
        {
            var joinRequest = await _tatawwa3DbContext.JoinRequests
                .FirstOrDefaultAsync(j => j.Id == joinRequestId);

            if (joinRequest == null)
                throw new Exception("الطلب غير موجود");

            joinRequest.Status = isAccepted ? RequestStatus.Accepted : RequestStatus.Rejected;

            if (isAccepted)
            {
                var teamMember = new TeamMember
                {
                    Id = Guid.NewGuid().ToString(),
                    TeamID = joinRequest.TeamId,
                    VolunteerID = joinRequest.VolunteerId,
                    Status = TeamMemberStatus.Accepted
                };

                await _tatawwa3DbContext.TeamMembers.AddAsync(teamMember);
            }

            await _tatawwa3DbContext.SaveChangesAsync();
            return isAccepted ? "تم قبول المتطوع في الفريق" : "تم رفض الطلب";
        }

       



    }
}
