using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tatawwa3.Application.CQRS.Organization.quiers
{
    public class GetAllCitiesQuery : IRequest<List<string>> { }
}
