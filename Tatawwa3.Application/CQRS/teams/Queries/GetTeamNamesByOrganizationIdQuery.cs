using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
   public class GetTeamNamesByOrganizationIdQuery: IRequest<List<string>>
    {
        public string orgId { get; set; }

        public GetTeamNamesByOrganizationIdQuery(string id)
        {
            orgId = id;
        }
    }
}
