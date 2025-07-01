using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerMangement.Commands
{
    public class AddNoteToApplicationCommand : IRequest<bool>
    {
        public string ApplicationId { get; set; }
        public string Note { get; set; }

        public AddNoteToApplicationCommand(string applicationId, string note)
        {
            ApplicationId = applicationId;
            Note = note;
        }
    }

    public class AddNoteToApplicationHandler : IRequestHandler<AddNoteToApplicationCommand, bool>
    {
        private readonly IApplicationService _applicationService;

        public AddNoteToApplicationHandler(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        public async Task<bool> Handle(AddNoteToApplicationCommand request, CancellationToken cancellationToken)
        {
            return await _applicationService.AddNoteAsync(request.ApplicationId, request.Note);
        }
    }
}
