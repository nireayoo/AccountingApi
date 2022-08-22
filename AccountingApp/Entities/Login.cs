using System.Text.Json.Serialization;

namespace AccountingApp.Data
{
    //this is going to serve as the database for login for my user.
    //Json ignore is used to hash passwords in ef core
    public class Login
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        public int LoginId { get; internal set; }
    }
}
