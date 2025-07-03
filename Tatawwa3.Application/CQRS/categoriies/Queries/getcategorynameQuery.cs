using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.CategoryDto;
using Tatawwa3.Domain.Entities;

namespace Tatawwa3.Application.CQRS.categoriies.Queries
{
    public class getcategorynameQuery:IRequest<List<categorynames>>
    {
    }
}
