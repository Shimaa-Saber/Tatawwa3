using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.VolunteerSettings.Command;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.VolunteerSettings.Handler
{
    public class UpdateVolunteerSettingsHandler : IRequestHandler<UpdateVolunteerSettingsCommand, bool>
    {
        private readonly Tatawwa3DbContext _context;

        public UpdateVolunteerSettingsHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateVolunteerSettingsCommand request, CancellationToken cancellationToken)
        {
            var volunteer = await _context.VolunteerProfiles
                .Include(v => v.User)
                .FirstOrDefaultAsync(v => v.Id == request.VolunteerId && !v.IsDeleted, cancellationToken);

            if (volunteer == null)
                return false;

            // Update properties
            volunteer.User.FullName = request.Dto.FullName;
            volunteer.User.Email = request.Dto.Email;
            volunteer.User.PhoneNumber = request.Dto.PhoneNumber;
            volunteer.User.City = request.Dto.City;
            volunteer.ProfilePictureUrl = request.Dto.Image;

            _context.VolunteerProfiles.Update(volunteer);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}
