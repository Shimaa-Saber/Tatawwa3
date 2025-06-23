using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.Dtos.AuthDtos;
using Tatawwa3.Application.Interfaces;

namespace Tatawwa3.Application.CQRS.Auth.Commands
{
    public class RegisterVolunteerCommand : IRequest<Unit>
    {
        public RegisterVolunteerDto Dto { get; set; }

        public RegisterVolunteerCommand(RegisterVolunteerDto dto)
        {
            Dto = dto;
        }
    }

    public class RegisterVolunteerHandler : IRequestHandler<RegisterVolunteerCommand, Unit>
    {
        private readonly IAuthService _AuthService;

        public RegisterVolunteerHandler(IAuthService AuthService)
        {
            _AuthService = AuthService;
        }

        public async Task<Unit> Handle(RegisterVolunteerCommand request, CancellationToken cancellationToken)
        {
            await _AuthService.RegisterVolunteerAsync(request.Dto);
            return Unit.Value;
        }
    }


}
