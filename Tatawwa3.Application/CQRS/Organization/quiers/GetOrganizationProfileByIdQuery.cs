using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile;

namespace Tatawwa3.Application.CQRS.Organization.quiers
{
   public class GetOrganizationProfileByIdQuery:IRequest<organisationdetails>
    {
        public string Id { get; set; }

        public GetOrganizationProfileByIdQuery(string id)
        {
            Id = id;
        }
    }
}
