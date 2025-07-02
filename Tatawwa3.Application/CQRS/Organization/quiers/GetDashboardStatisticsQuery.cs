using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.OrganizationProfile;
using MediatR;
namespace Tatawwa3.Application.CQRS.Organization.quiers
{
    public class GetDashboardStatisticsQuery : IRequest<DashboardStatisticsDTO>
    {

    }
}
