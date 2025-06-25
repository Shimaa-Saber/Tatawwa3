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
    public class ChangePasswordCommand: IRequest<bool>
    {
        public ChangePasswordDto Dto { get; }
        public string UserId { get; set; }
        public ChangePasswordCommand(ChangePasswordDto dto, string userId)
        {
            Dto = dto;
            UserId = userId;
        }
    }

    public class ChangePasswordHandler : IRequestHandler<ChangePasswordCommand, bool>
    {
        private readonly IAuthService _authService;

        public ChangePasswordHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<bool> Handle(ChangePasswordCommand request, CancellationToken cancellationToken)
        {
            return await _authService.ChangePasswordAsync(request.Dto, request.UserId);
        }
    }


}

