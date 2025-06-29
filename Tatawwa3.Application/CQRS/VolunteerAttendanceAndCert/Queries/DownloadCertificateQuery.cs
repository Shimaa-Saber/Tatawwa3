using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerAttendanceAndCert.Queries
{
    public class DownloadCertificateQuery : IRequest<byte[]>
    {
        public string CertificateId { get; set; }

        public DownloadCertificateQuery(string certificateId)
        {
            CertificateId = certificateId;
        }
    }
    public class DownloadCertificateHandler : IRequestHandler<DownloadCertificateQuery, byte[]>
    {
        private readonly IVolunteerService _service;

        public DownloadCertificateHandler(IVolunteerService service)
        {
            _service = service;
        }

        public async Task<byte[]> Handle(DownloadCertificateQuery request, CancellationToken cancellationToken)
        {
            return await _service.DownloadCertificateAsync(request.CertificateId);
        }
    }

}
