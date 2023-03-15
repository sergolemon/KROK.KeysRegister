using Persistence;

namespace WebAPI.Extensions
{
    public static class WebApplicationExtensions
    {
        public static WebApplication UseMiddleware(this WebApplication app)
        {
            app.MapControllers();
            app.UseOpenApi();
            app.UseSwaggerUi3();

            return app;
        }

        public static void CreateDatabaseIfNotExists(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();

            using var dbContext = scope.ServiceProvider.GetRequiredService<EfAppDbContext>();

            dbContext.Database.EnsureCreated();
        }
    }
}
