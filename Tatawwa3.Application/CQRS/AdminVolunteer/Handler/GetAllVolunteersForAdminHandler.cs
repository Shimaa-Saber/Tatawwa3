using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MediatR;
using Tatawwa3.Application.CQRS.AdminVolunteer.Quieries;
using Tatawwa3.Application.Dtos.AdminVolunteer;
using Tatawwa3.Infrastructure.Data;
using AutoMapper.QueryableExtensions;

namespace Tatawwa3.Application.CQRS.AdminVolunteer.Handler
{
    public class GetAllVolunteersForAdminHandler : IRequestHandler<GetAllVolunteersForAdminQuery, List<AdminVolunteerManagementDTO>>
    {
        private readonly Tatawwa3DbContext _context;
        private readonly IMapper _mapper;

        public GetAllVolunteersForAdminHandler(Tatawwa3DbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<AdminVolunteerManagementDTO>> Handle(GetAllVolunteersForAdminQuery request, CancellationToken cancellationToken)
        {
            var query = _context.VolunteerProfiles
                .Include(v => v.User)
                .Include(v => v.Participations)
                .Include(v => v.TeamsMemberships)
                .Where(v =>
    (string.IsNullOrEmpty(request.Name) || v.User.FullName.Contains(request.Name)) &&
    (string.IsNullOrEmpty(request.City) || v.User.City == request.City) &&
    (!request.Status.HasValue || v.Status == request.Status.Value) && // ✅ هنا
    (!request.Hours.HasValue || v.TotalHours >= request.Hours.Value)
)
                .ProjectTo<AdminVolunteerManagementDTO>(_mapper.ConfigurationProvider);

            return await query.ToListAsync(cancellationToken);
        }
    }
}
