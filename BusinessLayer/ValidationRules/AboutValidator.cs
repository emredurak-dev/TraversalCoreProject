using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator:AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x=>x.Description).NotEmpty().WithMessage("aciklama kismini bos gecemezsiniz...!");
            RuleFor(x => x.Image1).NotEmpty().WithMessage("lutfen gorsel seciniz...!");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("lutfen en az 50 karakterlik aciklama bilgisi giriniz...!");
            RuleFor(x => x.Description).MaximumLength(1500).WithMessage("lutfen aciklamayi kisaltin...!");
        }
    }
}
