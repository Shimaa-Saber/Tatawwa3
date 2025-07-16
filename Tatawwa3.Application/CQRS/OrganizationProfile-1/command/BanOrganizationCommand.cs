using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.command
{
    public class BanOrganizationCommand: IRequest<Unit>
    {
        public string OrganizationId { get; }

        public BanOrganizationCommand(string organizationId)
        {
            OrganizationId = organizationId;
        }
    }
}
