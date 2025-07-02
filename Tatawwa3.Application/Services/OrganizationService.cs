using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Infrastructure.Repositorirs;
using AutoMapper;
using System.Data.Entity;
using AutoMapper.QueryableExtensions;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Microsoft.EntityFrameworkCore;
namespace Tatawwa3.Application.Services
{
    public class OrganizationService : IOrganizationService
    {
        private readonly IGeneric<OrganizationProfile> _OrgRepo;
        private readonly IMapper _mapper;
        private readonly IOrganizationRepository _organizationRepository;
        public OrganizationService(IGeneric<OrganizationProfile> OrgRepo, IMapper mapper, IOrganizationRepository organizationRepository)
        {
            _OrgRepo = OrgRepo;
            _mapper = mapper;
            _organizationRepository = organizationRepository;
        }

        public async Task<List<OrganizationbasedFilterationDTO>> GetOrganizationByCityAsync(string city)
        {

            var organizations =  _organizationRepository.GetAll()
              .Where(o => o.City == city)
              .ToList();

            return _mapper.Map<List<OrganizationbasedFilterationDTO>>(organizations);

        }

        public async Task<List<OrganizationbasedFilterationDTO>> GetOrganizationByNameAsync(string name)
        {
            var organizationNames = _organizationRepository.GetAll().Where(o => o.OrganizationName == name).ToList();
            return _mapper.Map<List<OrganizationbasedFilterationDTO>>(organizationNames);


          
        }

        public async Task<OrganizationsStatisticsDTO> GetStatisticsAsync()
        {
            var total = await _OrgRepo.CountAsync();
            var active = await _OrgRepo.CountAsync(a => a.Status== OrganizationStatus.Approved);
            var pending = await _OrgRepo.CountAsync(p=>p.Status== OrganizationStatus.Pending);
            var rejected = await _OrgRepo.CountAsync(r=>r.Status== OrganizationStatus.Rejected);



            return new OrganizationsStatisticsDTO
            {
                TotalOrganizations = total,
                ActiveOrganizations = active,
                PendingOrganizations = pending,
                RejectedOrganizations = rejected
            };



        }
    }
}
