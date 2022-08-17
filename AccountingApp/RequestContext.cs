using AccountingApp.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountingApp
{
    public class RequestContext: IdentityDbContext<AppUser>
    {
        public RequestContext(DbContextOptions<RequestContext> options): base(options)
        {

        }
    }
}
