using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "lutfen adinizi giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "lutfen soyadinizi giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "lutfen kullanici adini giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "lutfen email adresinizi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "lutfen sifrenizi giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "lutfen sifrenizi tekrar giriniz.")]
        [Compare("Password", ErrorMessage = "sifreler uyumlu degil")]
        public string ConfirmPassword { get; set; }
    }
}
