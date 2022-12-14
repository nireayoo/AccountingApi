using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Model
{
    public class SignUpModel
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Email is required")]
        [Compare("ConfirmPassword")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        public bool RememberMe { get; set; }
        
    }
}
