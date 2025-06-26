using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Application.ViewModels;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;
namespace Tatawwa3.Application.MappingProfiles
{
    public class VolunteerOpportunityProfileForHomePage:Profile
    {
        public VolunteerOpportunityProfileForHomePage()
        {
            CreateMap<VolunteerOpportunity, OpportunityHomeDto>();
               
        }
    
    }
}
