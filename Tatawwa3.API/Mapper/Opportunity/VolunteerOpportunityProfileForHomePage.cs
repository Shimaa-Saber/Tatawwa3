using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Tatawwa3.Application.ViewModels;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.MappingProfiles
{
    public class VolunteerOpportunityProfileForHomePage:Profile
    {
        public VolunteerOpportunityProfileForHomePage()
        {
            CreateMap<VolunteerOpportunity, VolunteerOpportunityVM>()
                .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
                .ForMember(dest => dest.OrganizationName, opt => opt.MapFrom(src => src.Organization.OrganizationName));
        }
    
    }
}
