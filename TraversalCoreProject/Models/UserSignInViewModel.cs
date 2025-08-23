using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="lutfen kullanici adini giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "lutfen sifrenizi giriniz.")]
        public string password { get; set; }
    }
}
