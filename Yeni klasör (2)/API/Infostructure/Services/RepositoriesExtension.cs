using API.Repository;

namespace API.Infostructure.Services
{
    public static class RepositoriesExtension
    {
        public static WebApplicationBuilder AddAppRepositories(this WebApplicationBuilder builder)
        {
            // Add STI Repository
            builder.Services.AddScoped<ISTIRepository,STIRepository>();

            return builder;
        }
    }
}
