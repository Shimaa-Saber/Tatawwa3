using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.VolunteerOpportunities.Commands;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerOpportunities.Handlers
{
    public class UpdateOpportunityStatusHandler : IRequestHandler<UpdateOpportunityStatusCommand, string>
    {
        private readonly IOpportunity _repo;

        public UpdateOpportunityStatusHandler(IOpportunity repo)
        {
            _repo = repo;
        }

        public async Task<string> Handle(UpdateOpportunityStatusCommand request, CancellationToken cancellationToken)
        {
            var opportunity =  _repo.GetByID(request.OpportunityId);
            if (opportunity == null)
                return "الفرصة غير موجودة.";

            opportunity.Status = request.Status;

            _repo.UpdateByEntity(opportunity);
            await _repo.SaveChangesAsync();

            return "تم تحديث الحالة بنجاح.";
        }
    }

}
