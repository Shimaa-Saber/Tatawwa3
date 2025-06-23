using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
    public class GetCategoryOpportunitiesQuery: IRequest<List<GetAllOpportunitiesDto>>
    {
        public string categoryname { get; set; }

        public GetCategoryOpportunitiesQuery(string categoryname)
        {
            this.categoryname = categoryname;
        }
    }
}
