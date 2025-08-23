using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class GuideValidator:AbstractValidator<Guide>
    {
        public GuideValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("lutfen rehber adini giriniz.");
            RuleFor(x=>x.Description).NotEmpty().WithMessage("lutfen rehber aciklamasini giriniz.");
            RuleFor(x=>x.Image).NotEmpty().WithMessage("lutfen rehber gorselini giriniz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("lutfen rehber adini 50 karakterden daha az giriniz.");
            RuleFor(x => x.Name).MinimumLength(8).WithMessage("lutfen rehber adini en az 8 karakter giriniz.");
        }
    }
}
