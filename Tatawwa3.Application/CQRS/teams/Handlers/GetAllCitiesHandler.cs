using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.Dtos.Teams;
using Tatawwa3.Infrastructure.Data;
using Tatawwa3.Application.CQRS.teams.Queries;
namespace Tatawwa3.Application.CQRS.teams.Handlers
{
    public class GetAllCitiesHandler : IRequestHandler<GetAllCitiesQuery, List<CitiesDto>>
    {
        private readonly Tatawwa3DbContext _context;

        public GetAllCitiesHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public Task<List<CitiesDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
        {
            var cities = _context.Teams
                .Select(t => t.City)
                .Distinct()
                .ToList(); // Sync in EF6

            var result = cities
                .Where(c => !string.IsNullOrWhiteSpace(c))
                .Select(c => new CitiesDto { Name = c })
                .ToList();

            return Task.FromResult(result); // هنا ترجعي Task<List<CitiesDto>> زي ما الـ interface طالب
        }

    }
}
