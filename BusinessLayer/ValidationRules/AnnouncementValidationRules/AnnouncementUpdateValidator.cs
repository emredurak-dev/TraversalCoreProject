using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidationRules
{
    public class AnnouncementUpdateValidator:AbstractValidator<AnnouncementUpdateDTO>
    {
        public AnnouncementUpdateValidator()
        {
            //title
            RuleFor(x => x.Title).NotEmpty().WithMessage("lutfen basligi bos gecmeyin.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("lutfen en az 5 karakter veri girisi yapiniz.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("lutfen en fazla 50 karakter veri girisi yapiniz.");

            //content
            RuleFor(x => x.Content).NotEmpty().WithMessage("lutfen duyuru icerigini bos gecmeyin.");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("lutfen en az 20 karakter veri girisi yapiniz.");
            RuleFor(x => x.Content).MaximumLength(500).WithMessage("lutfen en fazla 500 karakter veri girisi yapiniz.");
        }
    }
}
