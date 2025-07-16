using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Tatawwa3.Application.CQRS.OrganizationProfile_1.command;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.OrganizationProfile_1.Handler
{
    public class BanOrganizationCommandHandler
        : IRequestHandler<BanOrganizationCommand, Unit>
    {
        private readonly IOrganizationRepository _orgRepo;

        public BanOrganizationCommandHandler(IOrganizationRepository orgRepo)
        {
            _orgRepo = orgRepo;
        }

        public async Task<Unit> Handle(
            BanOrganizationCommand request,
            CancellationToken cancellationToken)
        {
            var organization = await _orgRepo.GetByIdAsync(request.OrganizationId);

            if (organization == null)
                throw new KeyNotFoundException("Organization not found.");

            organization.IsBanned = true;
            organization.Status = OrganizationStatus.Rejected;
            _orgRepo.UpdateByEntity(organization);

            await _orgRepo.SaveChangesAsync();

            return Unit.Value;
        }
    }
}