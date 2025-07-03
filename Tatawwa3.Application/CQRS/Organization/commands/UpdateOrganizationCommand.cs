using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile;

namespace Tatawwa3.Application.CQRS.Organization.commands
{
    public class UpdateOrganizationCommand : IRequest<string>
    {
        public UpdateOrganizationDto Dto { get; set; }

        public UpdateOrganizationCommand(UpdateOrganizationDto dto)
        {
            Dto = dto;
        }
    }
}
