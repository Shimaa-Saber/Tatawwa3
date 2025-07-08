using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.Organization.commands
{
    public class DeleteOrganizationCommand : IRequest<string>
    {
        public string OrganizationId { get; set; }

        public DeleteOrganizationCommand(string organizationId)
        {
            OrganizationId = organizationId;
        }
    }
}
