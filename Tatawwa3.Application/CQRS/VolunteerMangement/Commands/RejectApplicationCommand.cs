using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Commands
{
    public class RejectApplicationCommand : IRequest<bool>
    {
        public string ApplicationId { get; set; }

        public RejectApplicationCommand(string applicationId)
        {
            ApplicationId = applicationId;
        }
    }

    public class RejectApplicationHandler : IRequestHandler<RejectApplicationCommand, bool>
    {
        private readonly IApplicationService _applicationService;

        public RejectApplicationHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<bool> Handle(RejectApplicationCommand request, CancellationToken cancellationToken)
        {
            return await _applicationService.RejectApplicationAsync(request.ApplicationId);
        }
    }
}
