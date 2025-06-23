using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Queries
{
  public  class GetAllOpportunitiesQuery: IRequest<List<GetAllOpportunitiesDto>>
    {
    }
}
