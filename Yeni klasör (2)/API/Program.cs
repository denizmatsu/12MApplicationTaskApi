using API.Entity;
using API.Infostructure.App;
using API.Infostructure.Services;
using API.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

            builder
                .AddAppConfiguration()
                .AddAppDbContext()
                .AddAppControllers()
                .AddAppSwagger()
                .AddAppRepositories()
                ;
            WebApplication app = builder.Build();
            builder.Configuration.AddEnvironmentVariables();

            app.UseAppSwagger()
                .UseAppHttpsRedirection()
                .UseAppAuthorization()
                .UseAppControllers()
                ;
            app.UseCors("AllowAll");
            app.Run();
        }
    }
}