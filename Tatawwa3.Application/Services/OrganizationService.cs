using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Infrastructure.Repositorirs;
namespace Tatawwa3.Application.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IGeneric<OrganizationProfile> _OrgRepo;
        private readonly IMapper _mapper;
        private readonly IOrganizationRepository _organizationRepository;
        private readonly Tatawwa3DbContext _context;
        public OrganizationService(IGeneric<OrganizationProfile> OrgRepo, IMapper mapper, IOrganizationRepository organizationRepository,
            Tatawwa3DbContext context
            )
        {
            _OrgRepo = OrgRepo;
            _mapper = mapper;
            _organizationRepository = organizationRepository;
            _context = context;
        }

        public async Task<List<OrganizationbasedFilterationDTO>> GetOrganizationByCityAsync(string city)
        {
            var organizations = await _organizationRepository.GetAll()
                .Where(o => o.City == city && !o.IsDeleted)
                .Include(o => o.VolunteerOpportunities) // ✅ لازم ده علشان نعرف نعد الفرص
               .Include(o => o.Teams)
                .ToListAsync();

            return _mapper.Map<List<OrganizationbasedFilterationDTO>>(organizations);
        }

        public async Task<List<OrganizationbasedFilterationDTO>> GetOrganizationByNameAsync(string name)
        {
            var organizationNames = await _organizationRepository
                .GetAll()
                .Where(o => o.OrganizationName == name && !o.IsDeleted)
                .Include(o => o.VolunteerOpportunities) // ✅ علشان OpportunitiesCount ما يكونش دايمًا 0
               .Include(o => o.Teams)
                .ToListAsync();

            return _mapper.Map<List<OrganizationbasedFilterationDTO>>(organizationNames);
        }

        public async Task<OrganizationsStatisticsDTO> GetStatisticsAsync()
        {
            var total = await _OrgRepo.CountAsync(o => !o.IsDeleted);
            var active = await _OrgRepo.CountAsync(a => a.Status == OrganizationStatus.Approved && !a.IsDeleted);
            var pending = await _OrgRepo.CountAsync(p => p.Status == OrganizationStatus.Pending && !p.IsDeleted);
            var rejected = await _OrgRepo.CountAsync(r => r.Status == OrganizationStatus.Rejected && !r.IsDeleted);



            return new OrganizationsStatisticsDTO
            {
                TotalOrganizations = total,
                ActiveOrganizations = active,
                PendingOrganizations = pending,
                RejectedOrganizations = rejected
            };



        }
        public async Task<List<OrganizationbasedFilterationDTO>> GetOrganizationsByStatusAsync(OrganizationStatus status)
        {
            var organizations = await _organizationRepository
                .GetAll()
              .Where(o => o.Status == status && !o.IsDeleted)
                .Include(o => o.VolunteerOpportunities)
               .Include(o => o.Teams)
                .ToListAsync();

            return _mapper.Map<List<OrganizationbasedFilterationDTO>>(organizations);
        }

        public async Task<OrganizationDetailsDto?> GetOrganizationDetailsAsync(string organizationId)
        {
            var organization = await _context.OrganizationProfiles
                .Include(o => o.ApplicationUser)
                .FirstOrDefaultAsync(o => o.Id == organizationId);

            if (organization == null) return null;

            var teams = await _context.Teams
                .Where(t => t.OrganizationID == organizationId)
                .Select(t => new SimpleTeamDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    CreatedAt = t.CreationDate
                }).ToListAsync();

            var opportunities = await _context.VolunteerOpportunities
                .Where(o => o.OrganizationID == organizationId)
                .Select(o => new SimpleOpportunityDto
                {
                    Id = o.Id,
                    Title = o.Title,
                    CreatedAt = o.CreatedAt
                }).ToListAsync();

            var totalVolunteers = await _context.Participations
                .Where(p => p.Opportunity.OrganizationID == organizationId)
                .Select(p => p.VolunteerID)
                .Distinct()
                .CountAsync();

            var totalCertificates = await _context.Certificates
                .CountAsync(c => c.Participation.Opportunity.OrganizationID == organizationId);

            return new OrganizationDetailsDto
            {
                Id = organization.Id,
                OrganizationName = organization.OrganizationName,
                Email = organization.Email,
                Phone = organization.PhoneNumber,
                City = organization.City,
                ProfileImage = organization.ProfilePictureUrl,
                CreatedAt = organization.CreatedAt,

                TotalOpportunities = opportunities.Count,
                TotalTeams = teams.Count,
                TotalVolunteers = totalVolunteers,
                TotalCertificates = totalCertificates,

                Teams = teams,
                Opportunities = opportunities
            };
        }

    }
}
