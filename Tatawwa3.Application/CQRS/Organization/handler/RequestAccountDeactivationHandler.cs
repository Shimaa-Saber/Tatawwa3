using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tatawwa3.Application.CQRS.Organization.commands;
using Tatawwa3.Domain.Interfaces;

namespace Tatawwa3.Application.CQRS.Organization.handler
{
   public class RequestAccountDeactivationHandler : IRequestHandler<RequestAccountDeactivationCommand, string>
    {
        private readonly IOrganizationRepository _repository;

        public RequestAccountDeactivationHandler(IOrganizationRepository repository)
        {
            _repository = repository;
        }
        public async Task<string> Handle(RequestAccountDeactivationCommand request, CancellationToken cancellationToken)
        {
            var org = _repository.GetByID(request.OrganizationId);
            if (org == null)
                throw new Exception("المنظمة غير موجودة");

            org.IsDeactivationRequested = true;
            _repository.UpdateByEntity(org);
            await _repository.SaveChangesAsync();

            return "تم إرسال طلب غلق الحساب بنجاح، في انتظار الموافقة.";
        }
    }
}
