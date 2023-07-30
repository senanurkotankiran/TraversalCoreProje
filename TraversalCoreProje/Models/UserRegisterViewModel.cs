using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProje.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen adınızı girin")]
        public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soy adınızı girin")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adınızı girin")]
		public string Username { get; set; }
		
		[Required(ErrorMessage = "Lütfen mail adresini girin")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Lütfen şifre girin")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar girin")]
		[Compare("Password", ErrorMessage ="Şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }


	}
}
