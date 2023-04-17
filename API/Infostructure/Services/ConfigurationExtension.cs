using Microsoft.AspNetCore.Hosting;

namespace API.Infostructure.Services
{
    public static class ConfigurationExtension
    {
        public static WebApplicationBuilder AddAppConfiguration(this WebApplicationBuilder builder)
        {
            // Load configuration settings from appsettings.json and appsettings.{Environment}.json
            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
                .Build();

            // Register IConfiguration instance with the services
            builder.Services.AddSingleton(configuration);
            builder.Services.AddCors(options => options.AddPolicy("AllowAll", p => p.AllowAnyOrigin()
                                                                            .AllowAnyMethod()
                                                                            .AllowAnyHeader()));
          
            return builder;
        }
    }
}
