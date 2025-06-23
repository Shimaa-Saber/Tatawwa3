using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunity.Queries
{
    public class GetLocationOpportunitiesQuery:IRequest<List<GetAllOpportunitiesDto>>
    {
        public string Location { get; set; }

        public GetLocationOpportunitiesQuery(string location)
        {
            Location = location;
        }
    }
}
