using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.teams.Commands
{
    public class RejectJoinRequestCommand : IRequest<string>
    {
        public string RequestId { get; set; }
        public RejectJoinRequestCommand(string requestId)
        {
            RequestId = requestId;
        }
    }

    public class RejectJoinRequestHandler : IRequestHandler<RejectJoinRequestCommand, string>
    {
        private readonly IJoinRequestService _service;

        public RejectJoinRequestHandler(IJoinRequestService service)
        {
            _service = service;
        }

        public async Task<string> Handle(RejectJoinRequestCommand request, CancellationToken cancellationToken)
        {
            return await _service.RejectJoinRequestAsync(request.RequestId);
        }
    }

}
