using AccountingApp.Model;
using Microsoft.AspNetCore.Identity;

namespace AccountingApp.Repository
{
    public class RequestRepository : IRequestRepository
    {
        private readonly RequestContext context;
        private readonly UserManager<AppUser> userManager;

        public RequestRepository(RequestContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
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
