using DTOLayer.DTOs.ContactDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.ContactUs
{
    public class SendContactUsValidator:AbstractValidator<SendMessageDto>
    {
        public SendContactUsValidator()
        {
            RuleFor(x=>x.Email).NotEmpty().WithMessage("email alani bos gecilemez.");
            RuleFor(x=>x.Subject).NotEmpty().WithMessage("konu alani bos gecilemez.");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("isim alani bos gecilemez.");
            RuleFor(x=>x.MessageBody).NotEmpty().WithMessage("mesaj alani bos gecilemez.");
            RuleFor(x=>x.Subject).MinimumLength(5).WithMessage("konu alanina en az 5 karakter veri girisi yapmaniz gerekli.");
            RuleFor(x=>x.Subject).MaximumLength(150).WithMessage("konu alanina en fazla 150 karakter veri girisi yapmaniz gerekli.");
            RuleFor(x => x.Email).MinimumLength(5).WithMessage("email alanina en az 5 karakter veri girisi yapmaniz gerekli.");
            RuleFor(x => x.Email).MaximumLength(150).WithMessage("email alanina en fazla 150 karakter veri girisi yapmaniz gerekli.");
        }
    }
}
