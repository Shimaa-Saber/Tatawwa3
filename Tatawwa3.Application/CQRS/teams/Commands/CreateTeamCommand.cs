using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.Team.Commands
{
    public class CreateTeamCommand: IRequest<string>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string City { get; set; }
        public bool IsLinkedToOpportunity { get; set; }
        public Domain.Enums.TeamJoinPermission JoinPermission { get; set; }
        public int? MaxMembers { get; set; }
        public string? InternalNotes { get; set; }
        public string OrganizationID { get; set; }
    }
}
