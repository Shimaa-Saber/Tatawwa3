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
    public class DeleteOrganizationHandler : IRequestHandler<DeleteOrganizationCommand, string>
    {
        private readonly IOrganizationRepository _repository;

        public DeleteOrganizationHandler(IOrganizationRepository repository)
        {
            _repository = repository;
        }

        public async Task<string> Handle(DeleteOrganizationCommand request, CancellationToken cancellationToken)
        {
            var org = _repository.GetByID(request.OrganizationId);
            if (org == null)
                return "المنظمة غير موجودة.";

            _repository.Remove(request.OrganizationId);
            await _repository.SaveChangesAsync();

            return "تم حذف المنظمة بنجاح.";
        }
    }
}
