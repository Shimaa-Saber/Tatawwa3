using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Tatawwa3.Application.CQRS.Team.Commands;
namespace Tatawwa3.Application.CQRS.teams.Validators
{
    public class CreateTeamCommandValidator : AbstractValidator<CreateTeamCommand>
    {
        public CreateTeamCommandValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("ادخل  اسم الفريق .");
            //.MaximumLength(100).WithMessage("اسم الفريق يجب ألا يزيد عن 100 حرف.");

            RuleFor(x => x.Description)
            .NotEmpty().WithMessage("الوصف مطلوب.");
            //.MaximumLength(500).WithMessage("الوصف طويل جدًا.");


            RuleFor(x => x.CategoryId)
               .GreaterThan(0).WithMessage("اختيار الفئة مطلوب.");

            RuleFor(x => x.City)
                .NotEmpty().WithMessage("المدينة مطلوبة.");

            RuleFor(x => x.OrganizationID)
                .NotEmpty().WithMessage("المنظمة مطلوبة.");

            RuleFor(x => x.MaxMembers)
                .GreaterThan(0).When(x => x.MaxMembers.HasValue);
                //.WithMessage("عدد الأعضاء يجب أن يكون أكبر من 0.");

        }
    }
}
