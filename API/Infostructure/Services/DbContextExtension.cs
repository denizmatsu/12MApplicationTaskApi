using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infostructure.Services
{
    public static class DbContextExtension
    {
        public static WebApplicationBuilder AddAppDbContext(this WebApplicationBuilder builder)
        {
            // Get Configuration
            IConfiguration configuration = builder.Configuration;

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Add DbContext
            builder.Services.AddDbContext<stokContext>(options =>
                options.UseSqlServer(connectionString));

            
            return builder;
        }
    }
}