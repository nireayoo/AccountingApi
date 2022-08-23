using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Model
{
    //this model is used for incoming requests, the user logs in with this model then it is passed into other methods to check for authentication
    public class AppUserRequest 
    {
        [Required]
        [EmailAddress(ErrorMessage ="email is required")]
        public string Email { get; set; } //acts as the username
        [Required]
        public string Password { get; set; }

    }
}
