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
    internal class DeleteOpportunityHandler : IRequestHandler<DeleteOpportunityCommand, string>
    {
        protected IOpportunity opportunity;
        public DeleteOpportunityHandler(IOpportunity opportunity) {
            this.opportunity = opportunity;

        }
        public async Task<string> Handle(DeleteOpportunityCommand request, CancellationToken cancellationToken)
        {
            var entity = opportunity.GetByID(request.Id);
            if (entity == null)
                return null;

            opportunity.Remove(request.Id);
            await opportunity.SaveChangesAsync();

            return " تم حذف الفرصة التطوعية بنجاح.";
        }
    }
}
