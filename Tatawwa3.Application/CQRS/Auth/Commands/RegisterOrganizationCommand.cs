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
    public class RegisterOrganizationCommand: IRequest
    {
        public RegisterOrganizationDto Dto { get; }

        public RegisterOrganizationCommand(RegisterOrganizationDto dto)
        {
            Dto = dto;
        }
    }

    public class RegisterOrganizationHandler : IRequestHandler<RegisterOrganizationCommand>
    {
        private readonly IAuthService _authService;

        public RegisterOrganizationHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task Handle(RegisterOrganizationCommand request, CancellationToken cancellationToken)
        {
            await _authService.RegisterOrganizationAsync(request.Dto);
           
        }
    }

}
