using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.ViewModels.Home
{
    public class UserVM
    {
        [Required]
        [Display(Name = "Nazwa użytkownika")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "Hasło must zawierać co najmniej osiem znaków, w tym co najmniej jedną cyfrę, a także małe i wielkie litery oraz znaki specjalne")]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [RegularExpression("@", ErrorMessage = "Uwzględnij znak @. Brak znaku @ w adresie email")]
        public string Email { get; set; }

        
        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
