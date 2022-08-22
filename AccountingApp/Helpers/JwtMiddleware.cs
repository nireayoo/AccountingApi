using Microsoft.Extensions.Options;

namespace AccountingApp.Helpers
{
    //this class is responsible for validating the token and attaching the authenticated user to the current endpoint
    public class JwtMiddleware
    {
        private readonly RequestDelegate next;
        private readonly IOptions<AppSettings> appSettings;

        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            this.next = next;
            this.appSettings = appSettings;
        }

        public async Task Invoke()
        {

        }

    }
}
