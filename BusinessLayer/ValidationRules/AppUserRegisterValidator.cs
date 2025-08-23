using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTOs>
    {
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("bu alani bos gecemezsiniz.");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("bu alani bos gecemezsiniz.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("bu alani bos gecemezsiniz.");
            RuleFor(x => x.Username).NotEmpty().WithMessage("bu alani bos gecemezsiniz.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("bu alani bos gecemezsiniz.");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("bu alani bos gecemezsiniz.");

            RuleFor(x => x.Username).MinimumLength(5).WithMessage("lutfen en az 5 karakter veri girisi yapinz.");
            RuleFor(x => x.Username).MaximumLength(20).WithMessage("lutfen en fazla 20 karakter veri girisi yapinz.");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("sifreler birbiriyle uyusmuyor.");
        }
    }
}
