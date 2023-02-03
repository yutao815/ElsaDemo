using Elsa.Extensions;

namespace ElsaDemo
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddElsa(elsa =>
            {
                // Expose API endpoints.
                elsa.UseWorkflowsApi();

                // Add services for HTTP activities and workflow middleware.
                elsa.UseHttp();
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseWorkflowsApi();
            app.UseWorkflows();
        }
    }
}
