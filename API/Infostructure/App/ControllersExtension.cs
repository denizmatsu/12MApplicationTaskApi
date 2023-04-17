using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infostructure.App
{
    public static class ControllersExtension
    {
        public static WebApplication UseAppControllers(this WebApplication app)
        {
            // Add Controllers
            app.MapControllers();

            return app;
        }
    }
}