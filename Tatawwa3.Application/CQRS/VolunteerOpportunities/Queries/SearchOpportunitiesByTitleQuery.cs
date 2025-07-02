using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class SearchOpportunitiesByTitleQuery : IRequest<List<searchDto>>
    {
        public string Title { get; set; }

        public SearchOpportunitiesByTitleQuery(string title)
        {
            Title = title;
        }
    }

}
