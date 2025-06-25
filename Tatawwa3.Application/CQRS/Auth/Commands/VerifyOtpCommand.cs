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
    public class VerifyOtpCommand : IRequest<bool>
    {
        public VerifyOtpDto Dto { get; }

        public VerifyOtpCommand(VerifyOtpDto dto)
        {
            Dto = dto;
        }
    }


    public class VerifyOtpHandler : IRequestHandler<VerifyOtpCommand, bool>
    {
        private readonly IAuthService _authService;

        public VerifyOtpHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task<bool> Handle(VerifyOtpCommand request, CancellationToken cancellationToken)
        {
            return await _authService.VerifyOtpAsync(request.Dto);
        }
    }


}
