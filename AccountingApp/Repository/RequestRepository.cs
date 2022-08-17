using AccountingApp.Model;
using Microsoft.AspNetCore.Identity;

namespace AccountingApp.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly UserManager<AppUser> userManager;

        public RequestRepository(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(SignUpModel signUpModel)
        {
            var user = new AppUser()
            {
                FirstName = signUpModel.FirstName,
                LastName = signUpModel.LastName,
                Email = signUpModel.Email,
                Role = signUpModel.Role,
            };
            return await userManager.CreateAsync(user, signUpModel.Password);
        }
    }
}
