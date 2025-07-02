using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
using Tatawwa3.Application.Dtos.Teams;

namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries
{
    public class GetOrganizationByCityQuery: IRequest<List<OrganizationbasedFilterationDTO>>
    {
        public string City { get; set; }
        public GetOrganizationByCityQuery(string city) 
        {
            City = city;
        }
    }
}
