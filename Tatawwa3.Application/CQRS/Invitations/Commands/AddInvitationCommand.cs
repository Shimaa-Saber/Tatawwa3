using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.InvitationDtos;



namespace Tatawwa3.Application.CQRS.Invitations.Commands
{
   public class AddInvitationCommand:IRequest<string>
    {
        public AddInvitaon addInvitaon {  get; set; }
        public AddInvitationCommand(AddInvitaon dto)
        {
            addInvitaon = dto;
        }


    }
}
