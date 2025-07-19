using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class AcceptJoinRequestCommand : IRequest<string>
    {
        public string RequestId { get; set; }
        public AcceptJoinRequestCommand(string requestId)
        {
            RequestId = requestId;
        }
    }

    public class AcceptJoinRequestHandler : IRequestHandler<AcceptJoinRequestCommand, string>
    {
        private readonly IJoinRequestService _service;

        public AcceptJoinRequestHandler(IJoinRequestService service)
        {
            _service = service;
        }

        public async Task<string> Handle(AcceptJoinRequestCommand request, CancellationToken cancellationToken)
        {
            return await _service.AcceptJoinRequestAsync(request.RequestId);
        }
    }

}
