//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.NetworkInformation;
//using System.Text;
//using System.Threading.Tasks;
//using Tatawwa3.Application.Dtos.Teams;
//using Tatawwa3.Application.Interfaces;
//using Tatawwa3.Domain.Entities;
//using Tatawwa3.Domain.Enums;
//using Tatawwa3.Domain.Interfaces;
//using Tatawwa3.Infrastructure.Data;

//namespace Tatawwa3.Application.Services
//{
//    public class StatisticsService:IStatisticsService
//    {
//        private readonly IGeneric<TeamMember> _memberRepo;
//        private readonly IGeneric<OrganizationProfile> _orgRepo;
//        private readonly IGeneric<Team> _teamRepo;

//        public StatisticsService(
//        IGeneric<TeamMember> memberRepo,
//        IGeneric<OrganizationProfile> orgRepo,
//        IGeneric<Team> teamRepo)
//        {
//            _memberRepo = memberRepo;
//            _orgRepo = orgRepo;
//            _teamRepo = teamRepo;
//        }

//        public async Task<TeamsStatisticsDto> GetTeamsStatisticsAsync()
//        {
//            var totalTeams = await _teamRepo.CountAsync();
//            var activeTeams = await _teamRepo.CountAsync(t => t.Status == TeamStatus.Active);
//            var totalMembers = await _memberRepo.CountAsync();
//            var totalOrganizations = await _orgRepo.CountAsync();

//            return new TeamsStatisticsDto
//            {
//                TotalTeams = totalTeams,
//                ActiveTeams = activeTeams,
//                TotalMembers = totalMembers,
//                TotalOrganizations = totalOrganizations
//            };
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.Services
{
    public class StatisticsService : IStatisticsService
    {
        private readonly IGeneric<TeamMember> _memberRepo;
        private readonly IGeneric<OrganizationProfile> _orgRepo;
        private readonly IGeneric<Team> _teamRepo;
        private readonly Tatawwa3DbContext _context;

        public StatisticsService(
            IGeneric<TeamMember> memberRepo,
            IGeneric<OrganizationProfile> orgRepo,
            IGeneric<Team> teamRepo,
        Tatawwa3DbContext context)
        {
            _memberRepo = memberRepo;
            _orgRepo = orgRepo;
            _teamRepo = teamRepo;
            _context = context;
        }

      
            // استخدام GetAllAsync لحساب البيانات مؤقتًا
           public async Task<TeamsStatisticsDto> GetTeamsStatisticsAsync()
        {
            var totalTeams = await _teamRepo.CountAsync();
            var activeTeams = await _teamRepo.CountAsync(t => t.Status == TeamStatus.Active);

            // ✅ ده يحسب العدد الفعلي لأعضاء الفرق (Accepted فقط)
            var totalMembers = await _context.TeamMembers.CountAsync(m => m.Status == TeamMemberStatus.Accepted);

            var totalOrganizations = await _orgRepo.CountAsync();

            return new TeamsStatisticsDto
            {
                TotalTeams = totalTeams,
                ActiveTeams = activeTeams,
                TotalMembers = totalMembers,
                TotalOrganizations = totalOrganizations
            };
        }

    }
}
