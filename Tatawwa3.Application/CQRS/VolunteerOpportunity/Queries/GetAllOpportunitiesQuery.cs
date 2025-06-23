using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

using Tatawwa3.Application.Dtos.VolunteerOpportunity;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunity.Queries
{
  public  class GetAllOpportunitiesQuery: IRequest<List<GetAllOpportunitiesDto>>
    {
    }
}
