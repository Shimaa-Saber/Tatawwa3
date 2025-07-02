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
    public record IssueCertificateCommand(IssueCertificateDto Dto) : IRequest<bool>;

    public class IssueCertificateHandler : IRequestHandler<IssueCertificateCommand, bool>
    {
        private readonly ICertificateService _service;

        public IssueCertificateHandler(ICertificateService service)
        {
            _service = service;
        }

        public async Task<bool> Handle(IssueCertificateCommand request, CancellationToken cancellationToken)
        {
            return await _service.IssueCertificateAsync(request.Dto);
        }
    }


}
