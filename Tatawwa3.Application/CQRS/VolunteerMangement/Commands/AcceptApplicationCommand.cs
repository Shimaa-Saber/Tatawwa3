using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Commands
{
    public class AcceptApplicationCommand : IRequest<bool>
    {
        public string ApplicationId { get; set; }

        public AcceptApplicationCommand(string applicationId)
        {
            ApplicationId = applicationId;
        }
    }

    public class AcceptApplicationHandler : IRequestHandler<AcceptApplicationCommand, bool>
    {
        private readonly IApplicationService _applicationService;

        public AcceptApplicationHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<bool> Handle(AcceptApplicationCommand request, CancellationToken cancellationToken)
        {
            return await _applicationService.AcceptApplicationAsync(request.ApplicationId);
        }
    }
}
