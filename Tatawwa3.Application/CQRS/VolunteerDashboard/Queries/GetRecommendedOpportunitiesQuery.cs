using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.VolunteerDashboard;

namespace Tatawwa3.Application.CQRS.VolunteerDashboard.Queries
{
    public class GetRecommendedOpportunitiesQuery : IRequest<List<RecommendedOpportunityDto>>
    {
        public string VolunteerId { get; set; }

        public GetRecommendedOpportunitiesQuery(string volunteerId)
        {
            VolunteerId = volunteerId;
        }
    }
}
