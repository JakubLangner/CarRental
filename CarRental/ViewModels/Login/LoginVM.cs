using System.ComponentModel.DataAnnotations;

namespace CarRental.ViewModels
{
    public class LoginVM
    { 
        [Required(ErrorMessage ="Nazwa użytkownika jest wymagana")]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Podanie hasła jest wymagane")]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej osiem znaków, w tym co najmniej jedną cyfrę, a także małe i wielkie litery oraz znaki specjalne")]
        public string Password { get; set; }
    }
}
