using AutoMapper;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.API.Mapper.Organization
{
    public class organizationprofile:Profile
    {
        public organizationprofile()
        {
            CreateMap<OrganizationProfile, OrganizationbasedFilterationDTO>();
        }
    }
}
