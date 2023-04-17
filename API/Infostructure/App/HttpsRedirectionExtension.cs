using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infostructure.App
{
    public static class HttpsRedirectionExtension
    {
        public static WebApplication UseAppHttpsRedirection(this WebApplication app)
        {
            // Add HttpsRedirection
            app.UseHttpsRedirection();

            return app;
        }
    }
}