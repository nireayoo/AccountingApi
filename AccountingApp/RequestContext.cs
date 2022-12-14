using AccountingApp.Data;
using AccountingApp.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AccountingApp
{
    public class RequestContext: DbContext
    {
        public RequestContext(DbContextOptions<RequestContext> options): base(options)
        {

        }
        public DbSet<Login> Logins { get; set; }
    }
}
