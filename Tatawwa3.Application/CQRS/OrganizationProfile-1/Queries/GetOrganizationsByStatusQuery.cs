using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Domain.Enums;

namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries
{
    public class GetOrganizationsByStatusQuery : IRequest<List<OrganizationbasedFilterationDTO>>
    {
        public OrganizationStatus Status { get; set; }

        public GetOrganizationsByStatusQuery(OrganizationStatus status)
        {
            Status = status;
        }
    }
}
