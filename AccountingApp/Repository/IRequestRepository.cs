using AccountingApp.Model;
using Microsoft.AspNetCore.Identity;

namespace AccountingApp.Repository
{
    public interface IRequestRepository
    {
        //Task<IdentityResult> AddUserAsync(SignUpModel signUpModel);

        Task<IdentityResult> AddUserAsync(SignUpModel signUpModel);

    }
}