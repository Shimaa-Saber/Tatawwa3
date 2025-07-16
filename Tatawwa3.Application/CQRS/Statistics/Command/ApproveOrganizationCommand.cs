using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.Statistics.Command
{
    public class ApproveOrganizationCommand : IRequest<Unit>
    {
        public string OrganizationId { get; set; }

        public ApproveOrganizationCommand(string organizationId)
        {
            OrganizationId = organizationId;
        }
    }
}
