using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class SearchMangeVolunteerTeamsByNameQuery : IRequest<List<MangeVolunteerTeamsDto>>
    {
        public string Name { get; set; }

        public SearchMangeVolunteerTeamsByNameQuery(string name)
        {
            Name = name;
        }
    }
}
