using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.OrganizationProfile_1;
namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.Queries
{
    public class GetOrganizationByNameQuery : IRequest<List<OrganizationbasedFilterationDTO>>
    {
        public string Name { get; set; }
        public GetOrganizationByNameQuery(string name)
        {
            Name = name;
        }
    }
}
