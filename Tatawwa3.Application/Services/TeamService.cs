using AutoMapper;
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

        public TeamService(
            IGeneric<Team> teamRepo,
            IGeneric<JoinRequest> joinRequestRepo,
            Tatawwa3DbContext tatawwa3DbContext,
            ITeamRepository teamRepository,
            IMapper mapper

        )
        {
            _teamRepo = teamRepo;
            _joinRequestRepo = joinRequestRepo;
            _tatawwa3DbContext = tatawwa3DbContext;
            _teamRepository = teamRepository;
            _mapper = mapper;
        }

        public async Task<List<GetTeamaDto>> GetAllTeamsAsync()
        {
            var query = _teamRepository.GetAllTeams()
              .ProjectTo<GetTeamaDto>(_mapper.ConfigurationProvider);
            return await query.ToListAsync();
        }

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

       
    }
}
