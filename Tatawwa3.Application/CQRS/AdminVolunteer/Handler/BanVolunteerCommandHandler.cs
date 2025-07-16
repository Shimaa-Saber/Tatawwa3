using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.AdminVolunteer.Commit;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.AdminVolunteer.Handler
{
    public class BanVolunteerCommandHandler : IRequestHandler<BanVolunteerCommand, bool>
    {
        private readonly Tatawwa3DbContext _context;

        public BanVolunteerCommandHandler(Tatawwa3DbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(BanVolunteerCommand request, CancellationToken cancellationToken)
        {
            var volunteer = await _context.VolunteerProfiles
                .FirstOrDefaultAsync(v => v.Id == request.VolunteerId, cancellationToken);

            if (volunteer == null) return false;

            volunteer.IsBanned = true;

            _context.VolunteerProfiles.Update(volunteer);
            await _context.SaveChangesAsync(cancellationToken);

            return true;
        }
    }
}