using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerTeams;
using MediatR;
namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetVolunteerTeamsQuery: IRequest<List<VolunteerTeamDto>>
    {
    }
}
