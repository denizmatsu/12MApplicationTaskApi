namespace API.Infostructure.Services
{
    public static class SwaggerExtension
    {
        public static WebApplicationBuilder AddAppSwagger(this WebApplicationBuilder builder)
        {

            // Register the Swagger generator, defining 1 or more Swagger documents
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            return builder;
        }
    }
}
