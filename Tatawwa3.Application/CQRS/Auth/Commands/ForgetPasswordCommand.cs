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
    public class ForgetPasswordCommand: IRequest
    {
        public ForgotPasswordDto Dto { get; set; }

        public ForgetPasswordCommand(ForgotPasswordDto dto)
        {
            Dto = dto;
        }
    }


    public class ForgetPasswordHandler : IRequestHandler<ForgetPasswordCommand>
    {
        private readonly IAuthService _authService;

        public ForgetPasswordHandler(IAuthService authService)
        {
            _authService = authService;
        }

        public async Task Handle(ForgetPasswordCommand request, CancellationToken cancellationToken)
        {
            await _authService.ForgetPasswordAsync(request.Dto);
        }
    }




}
