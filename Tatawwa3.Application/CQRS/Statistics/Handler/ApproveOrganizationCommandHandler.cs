using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.Statistics.Command;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;
using Tatawwa3.Infrastructure.Data;

namespace Tatawwa3.Application.CQRS.Statistics.Handler
{
    public class ApproveOrganizationCommandHandler : IRequestHandler<ApproveOrganizationCommand, Unit>
    {
        private readonly IOrganizationRepository _organizationRepository;
        private readonly Tatawwa3DbContext _context;
        public ApproveOrganizationCommandHandler(IOrganizationRepository organizationRepository , Tatawwa3DbContext context)
        {
            _organizationRepository = organizationRepository;
            _context = context;
        }

        public async Task<Unit> Handle(ApproveOrganizationCommand request, CancellationToken cancellationToken)
        {
            var organization = await _organizationRepository.GetByIdAsync(request.OrganizationId);
            if (organization == null)
                throw new Exception("Organization not found.");

            organization.Status = OrganizationStatus.Approved;
            //_organizationRepository.UpdateByEntity(organization); // لو بتستخدم Track changes
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }

}
