namespace API.Infostructure.Services
{
    public static class ControllersExtension
    {
        public static WebApplicationBuilder AddAppControllers(this WebApplicationBuilder builder)
        {
            // Add Controllers
            builder.Services.AddControllers();

            return builder;
        }
    }
}
