
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
    public class RegisterOrganizationCommand : IRequest<Unit>
    {
        public RegisterOrganizationDto Dto { get; }

        public RegisterOrganizationCommand(RegisterOrganizationDto dto)
        {
            Dto = dto;
        }
    }

    public class RegisterOrganizationHandler : IRequestHandler<RegisterOrganizationCommand, Unit>
    {
        private readonly IAuthService _authService;

        public RegisterOrganizationHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<Unit> Handle(RegisterOrganizationCommand request, CancellationToken cancellationToken)
        {
            await _authService.RegisterOrganizationAsync(request.Dto);
            return Unit.Value;
        }
    }

}
