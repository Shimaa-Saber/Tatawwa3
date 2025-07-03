using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.teams.Queries;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetAllCategoriesHandler : IRequestHandler<GetAllCategoriesQuery, List<CaregoriesDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetAllCategoriesHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public Task<List<CaregoriesDto>> Handle(GetAllCategoriesQuery request, CancellationToken cancellationToken)
        {
            var result = _context.Categories
                .Select(c => new CaregoriesDto
                {
                    Name = c.Name,

                })
                .ToList(); // Sync لأنه EF6

            return Task.FromResult(result);
        }
    }
}
