using AccountingApp.Data;
using System.ComponentModel.DataAnnotations;

namespace AccountingApp.Model
{
    //this model is returned after a successful authentication
    public class LoginAuthenticateModel
    {
        public int LoginId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }

        public LoginAuthenticateModel(Login user, string token)
        {
            LoginId = user.LoginId;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Role = user.Role;
            Email = user.Email;   
            Token = token;

        }

    }
    
}
