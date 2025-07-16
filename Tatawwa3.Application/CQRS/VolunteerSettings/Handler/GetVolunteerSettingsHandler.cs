using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.VolunteerSettings.Quiers;
using Tatawwa3.Application.Dtos.VolunteerSettings;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.VolunteerSettings.Handler
{
    public class GetVolunteerSettingsHandler : IRequestHandler<GetVolunteerSettingsQuery, VolunteerSettingsDto>
    {
        private readonly Tatawwa3DbContext _context;

        public GetVolunteerSettingsHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<VolunteerSettingsDto> Handle(GetVolunteerSettingsQuery request, CancellationToken cancellationToken)
        {
            var volunteer = await _context.VolunteerProfiles
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.Id == request.VolunteerId && !v.IsDeleted, cancellationToken);

            if (volunteer == null)
                return null;

            return new VolunteerSettingsDto
            {
                Id = volunteer.Id,
                FullName = volunteer.User.FullName,
                Email = volunteer.User.Email,
                Image = volunteer.ProfilePictureUrl,
                PhoneNumber = volunteer.User.PhoneNumber,
                City = volunteer.User.City
            };
        }
    }
}
