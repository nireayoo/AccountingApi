using AccountingApp.Model;
using Microsoft.AspNetCore.Identity;

namespace AccountingApp.Repository
{
    public interface IRequestRepository
    {
        //Task<IdentityResult> AddUserAsync(SignUpModel signUpModel);
        Task<List<UserLoginModel>> GetUserAsync();
        Task<UserLoginModel> AddUserAsync(UserLoginModel userLogin);
    }
}