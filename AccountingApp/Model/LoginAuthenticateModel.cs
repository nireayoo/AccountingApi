using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Model
{
    public class LoginAuthenticateModel
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
      
    }
}
