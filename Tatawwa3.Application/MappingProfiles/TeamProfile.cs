using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Tatawwa3.Application.CQRS.Team.Commands;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.MappingProfiles
{
    public class TeamProfile:Profile
    {
        public TeamProfile()
        {
            CreateMap<CreateTeamCommand, Team>();
        }
    }
}
