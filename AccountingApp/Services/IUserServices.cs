using AccountingApp.Data;
using AccountingApp.Model;

namespace AccountingApp.Services
{
    public interface IUserServices
    {
        LoginAuthentication Authenticate(AppUserRequest model);
        IEnumerable<Login> GetAll();
        Login GetById(int id);

    }
}