using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.Statistics.Queries;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Statistics.Handler
{
    public class GetWeeklyVolunteerActivityRatioQueryHandler : IRequestHandler<GetWeeklyVolunteerActivityRatioQuery, double>
    {
        private readonly IParticipationRepository _participationRepo;
        private readonly IVolunteerProfileRepository _volunteerRepo;

        public GetWeeklyVolunteerActivityRatioQueryHandler(
            IParticipationRepository participationRepo,
            IVolunteerProfileRepository volunteerRepo)
        {
            _participationRepo = participationRepo;
            _volunteerRepo = volunteerRepo;
        }

        public async Task<double> Handle(GetWeeklyVolunteerActivityRatioQuery request, CancellationToken cancellationToken)
        {
            var oneWeekAgo = DateTime.UtcNow.AddDays(-7);

            var totalVolunteers = await _volunteerRepo.CountAsync();
            if (totalVolunteers == 0)
                return 0;

            var weeklyParticipations = await _participationRepo.CountAsync(p => p.CreatedAt >= oneWeekAgo);

            var ratio = (double)weeklyParticipations / totalVolunteers;
            return Math.Round(ratio * 100, 2); // يرجع النسبة المئوية
        }
    }
}
