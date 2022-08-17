using Microsoft.AspNetCore.Identity;

namespace AccountingApp.Model
{
    public class AppUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
    }
}
