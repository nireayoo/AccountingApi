using AccountingApp.Data;
using AccountingApp.Helpers;
using AccountingApp.Model;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AccountingApp.Services
{
    //this class is where all the logic, validation of token takes place
    public class UserServices: IUserServices
    {
        private readonly RequestContext context;
        private readonly AppSettings appSettings;

        public UserServices(RequestContext context, AppSettings appSettings)
        {
           
            this.context = context;
            this.appSettings = appSettings;
        }

        private List<Login> users = new List<Login>
        {
            //will still try this with a database
            new Login{LoginId = 1, FirstName = "Dry", LastName = "Rocks", Email= "mikerocks@yahoo.com", Password= "theboy2002", Role= "admin"}

        };
        //trying to generate the jwt token
        public LoginAuthentication Authenticate(AppUserRequest model)
        {
            var user = users.SingleOrDefault(x =>x.Email == model.Email && x.Password == model.Password);
            if (user == null) return null;
            //returns null if user is not found
            var token = generateJwtToken(user);
            return new LoginAuthentication(user, token);

         }
        public Login GetById(int id)
        {
            return users.FirstOrDefault(x => x.LoginId == id);
        }
        

        public IEnumerable<Login> GetAll()
        {
            return users;

        }
       
        //tis class is a set of codes responsible for token generations
        private string generateJwtToken(Login user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.LoginId.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);

        }
       
    }
}
