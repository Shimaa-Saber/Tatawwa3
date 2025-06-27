using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.InvitationDtos;

namespace Tatawwa3.Application.CQRS.Invitations.Queries
{
    public class GetSentInvitationsQuery:IRequest<List<SentInvitationDto>>
    {
    }
}
