using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.Certificats;
using Tatawwa3.Application.Interfaces;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Domain.Enums;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Certificates.Queries
{
    public record GetCompletedParticipantsQuery(string Opp_title) : IRequest<List<CompletedParticipantDto>>;
   

    public class GetCompletedParticipantsHandler : IRequestHandler<GetCompletedParticipantsQuery, List<CompletedParticipantDto>>
    {
        private readonly ICertificateService _certificateService;

        public GetCompletedParticipantsHandler(ICertificateService certificateService)
        {
            _certificateService = certificateService;
        }

        public async Task<List<CompletedParticipantDto>> Handle(GetCompletedParticipantsQuery request, CancellationToken cancellationToken)
        {
            return await _certificateService.GetCompletedParticipantsForOrganizationAsync(request.Opp_title);
        }
    }


}
