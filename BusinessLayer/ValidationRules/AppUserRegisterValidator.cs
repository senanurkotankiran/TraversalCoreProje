using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AppUserRegisterValidator : AbstractValidator<AppUserRegisterDTO>
	{

		public AppUserRegisterValidator()
		{
			RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
			RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
			RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş geçilemez");
			RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
			RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");
			RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş geçilemez");
			RuleFor(x => x.Password).Equal(y=>y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor. Tekrar deneyin");
			RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adınız en az 3 karakterli olmalıdır!");

		}

	}
}
