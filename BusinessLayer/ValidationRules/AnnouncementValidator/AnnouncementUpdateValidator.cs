using DTOLayer.DTOs.AnnouncementDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.AnnouncementValidator.AnnouncementValidator
{
    public class AnnouncementUpdateValidator : AbstractValidator<AnnouncementAddDTO>
    {
        public AnnouncementUpdateValidator()
        {
            
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen başlık giriniz");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Lütfen duyuru içeriği giriniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen en az 5 karakter veri giriniz");
            RuleFor(x => x.Content).MinimumLength(20).WithMessage("Lütfen en az 20 karakter veri giriniz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Lütfen en fazla 50 karakter veri giriniz");

        }
    }
}
