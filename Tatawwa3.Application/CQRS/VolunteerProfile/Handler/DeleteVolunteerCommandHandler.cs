using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Tatawwa3.Application.CQRS.VolunteerProfile.Commands;
using Tatawwa3.Domain.Entities;
using Tatawwa3.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using Tatawwa3.Application.CQRS.Organization.commands;
using Tatawwa3.Domain.Interfaces;
namespace Tatawwa3.Application.CQRS.VolunteerProfile.Handler
{


    public class DeleteVolunteerCommandHandler : IRequestHandler<DeleteVolunteerCommand, string>
    {
        private readonly IVolunteerProfileRepository _repository;
        private readonly UserManager<ApplicationUser> _userManager;

        public DeleteVolunteerCommandHandler(
            IVolunteerProfileRepository repository,
            UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }

        public async Task<string> Handle(DeleteVolunteerCommand request, CancellationToken cancellationToken)
        {
            // 1. هات الفولنتير
            var volunteer = await _repository.GetByUserIdAsync(request._UserId);
            if (volunteer == null)
                return "المتطوع غير موجود.";

            // 2. احذف الـ VolunteerProfile
            await _repository.Remove(volunteer);

            // 3. احذف الـ ApplicationUser نفسه
            var user = await _userManager.FindByIdAsync(request._UserId);
            if (user != null)
            {
                await _userManager.DeleteAsync(user); // ✅ صح كده
            }

            return "تم حذف المتطوع بنجاح.";
        }
    }
}

