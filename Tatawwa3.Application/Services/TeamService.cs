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
           .Include(t => t.Members)
           .ThenInclude(m => m.Volunteer)
            .ThenInclude(v => v.User)
           .Include(t => t.Opportunities)
            .FirstOrDefaultAsync(t => t.Id == teamId);

            if (team == null)
                throw new Exception("Team not found");

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
    }
}
