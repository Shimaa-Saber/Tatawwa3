using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Certificats;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Certificates.Commands
{
    public record IssueGroupCertificatesCommand(IssueGroupCertificatesDto Dto) : IRequest<int>;
    public class IssueGroupCertificatesHandler : IRequestHandler<IssueGroupCertificatesCommand, int>
    {
        private readonly ICertificateService _service;

        public IssueGroupCertificatesHandler(ICertificateService service)
        {
            _service = service;
        }

        public async Task<int> Handle(IssueGroupCertificatesCommand request, CancellationToken cancellationToken)
        {
            return await _service.IssueGroupCertificatesAsync(request.Dto);
        }
    }

}
