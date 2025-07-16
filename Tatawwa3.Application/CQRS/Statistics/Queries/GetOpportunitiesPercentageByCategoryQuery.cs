using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos;

namespace Tatawwa3.Application.CQRS.Statistics.Queries
{
    public class GetOpportunitiesPercentageByCategoryQuery : IRequest<List<CategoryPercentageDto>>
    {
    }
}
