using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Model
{
    public class AppUser 
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

    }
}
