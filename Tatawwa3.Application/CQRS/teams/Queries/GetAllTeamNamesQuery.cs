using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.teams.Queries
{
    public class GetAllTeamNamesQuery : IRequest<List<string>> { }
}
