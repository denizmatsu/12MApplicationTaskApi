using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Infostructure.App
{
    public static class SwaggerExtension
    {
        public static WebApplication UseAppSwagger(this WebApplication app)
        {
            // If is development environment
            if (app.Environment.IsDevelopment())
            {
                // Add Swagger
                app.UseSwagger();
                // Add Swagger UI
                app.UseSwaggerUI();
                
            }

            return app;
        }
    }
}