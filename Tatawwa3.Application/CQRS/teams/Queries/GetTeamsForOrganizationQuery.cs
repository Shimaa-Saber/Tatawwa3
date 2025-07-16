using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetTeamsForOrganizationQuery : IRequest<List<TeamForOrganizationDto>>
    {
        public string OrganizationId { get; set; }

        public GetTeamsForOrganizationQuery(string organizationId)
        {
            OrganizationId = organizationId;
        }
    }
}
