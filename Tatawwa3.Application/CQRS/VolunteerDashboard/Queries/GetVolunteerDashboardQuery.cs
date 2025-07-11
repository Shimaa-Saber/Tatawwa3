using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.VolunteerDashboard;

namespace Tatawwa3.Application.CQRS.VolunteerDashboard.Queries
{
    public class GetVolunteerDashboardQuery : IRequest<List<SubmittedOpportunityDto>>
    {
        public string UserId { get; set; }

        public GetVolunteerDashboardQuery(string userId)
        {
            UserId = userId;
        }
    }
}
