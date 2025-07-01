using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.VolunteerAttendanceAndCert;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.VolunteerAttendanceAndCert.Queries
{
    public class GetVolunteerCertificatesQuery : IRequest<List<CertificateDto>>
    {
        public string VolunteerId { get; set; }

        public GetVolunteerCertificatesQuery(string volunteerId)
        {
            VolunteerId = volunteerId;
        }
    }

    public class GetVolunteerCertificatesHandler : IRequestHandler<GetVolunteerCertificatesQuery, List<CertificateDto>>
    {
        private readonly IVolunteerService _certificateService;

        public GetVolunteerCertificatesHandler(IVolunteerService certificateService)
        {
            _certificateService = certificateService;
        }

        public async Task<List<CertificateDto>> Handle(GetVolunteerCertificatesQuery request, CancellationToken cancellationToken)
        {
            return await _certificateService.GetVolunteerCertificatesAsync(request.VolunteerId);
        }
    }

}
