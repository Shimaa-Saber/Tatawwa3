using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Certificates.Queries;
using Tatawwa3.Application.Dtos.Certificats;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Certificates.Queries
{
    public class GetAllCompletedOrgParQuery : IRequest<List<CompletedParticipantDto>>
    {
        public string OrgId { get; set; }
        public GetAllCompletedOrgParQuery(string orgId)
        {
            OrgId = orgId;
        }
    }
    public class GetAllCompletedOrgParQueryHandler : IRequestHandler<GetAllCompletedOrgParQuery, List<CompletedParticipantDto>>
    {
        private readonly ICertificateService _certificateService;
        public GetAllCompletedOrgParQueryHandler(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }
        public async Task<List<CompletedParticipantDto>> Handle(GetAllCompletedOrgParQuery request, CancellationToken cancellationToken)
        {
            return await _certificateService.GetAllCompletedParticipantsForOrganizationAsync(request.OrgId);
        }




    }
}


      




