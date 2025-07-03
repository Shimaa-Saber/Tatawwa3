using AutoMapper;
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
    public class UpdateOrganizationHandler : IRequestHandler<UpdateOrganizationCommand, string>
    {
        private readonly IOrganizationRepository _repository;
        private readonly IMapper _mapper;

        public UpdateOrganizationHandler(IOrganizationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<string> Handle(UpdateOrganizationCommand request, CancellationToken cancellationToken)
        {
            var dto = request.Dto;
            var org =  _repository.GetByID(dto.Id);
            if (org == null)
                return "Organization not found.";

            // تحديث الحقول باستخدام AutoMapper
            _mapper.Map(dto, org);

            if (dto.LogoFile != null && dto.LogoFile.Length > 0)
            {
                var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");
                Directory.CreateDirectory(uploadsFolder);

                var fileName = Guid.NewGuid().ToString() + Path.GetExtension(dto.LogoFile.FileName);
                var fullPath = Path.Combine(uploadsFolder, fileName);

                using var stream = new FileStream(fullPath, FileMode.Create);
                await dto.LogoFile.CopyToAsync(stream, cancellationToken);

                org.ProfileImage = Path.Combine("uploads", fileName).Replace("\\", "/");
            }

             _repository.UpdateByEntity(org);
            _repository.SaveChangesAsync();


            return "تم التعديل بنجاح";
        }
    }
}
