using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.AdminDashbord;

namespace Tatawwa3.Application.CQRS.DashBord_Admin.Queries
{
    public class GetDashboardQuery:IRequest<DashboardDto>
    {
    }
}
