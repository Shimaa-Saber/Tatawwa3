using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.Statistics.Command;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Statistics.Handler
{
    public class ApproveOrganizationCommandHandler : IRequestHandler<ApproveOrganizationCommand, Unit>
    {
        private readonly IOrganizationRepository _organizationRepository;

        public ApproveOrganizationCommandHandler(IOrganizationRepository organizationRepository)
        {
            _organizationRepository = organizationRepository;
        }

        public async Task<Unit> Handle(ApproveOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = await _organizationRepository.GetByIdAsync(request.OrganizationId);
            if (organization == null)
                throw new Exception("Organization not found.");

            organization.Status = OrganizationStatus.Approved;
            _organizationRepository.UpdateByEntity(organization); // لو بتستخدم Track changes
            return Unit.Value;
        }
    }

}
