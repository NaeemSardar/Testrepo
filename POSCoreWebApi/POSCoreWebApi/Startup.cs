using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using POSCoreWebApi.Models;
namespace POSCoreWebApi
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            //NS: I've integrated pipe line with database through MainContext class which is used for  connection to create database table 
            services.AddDbContext<ApplicationDbContext>(db => db.UseSqlServer(Configuration.GetConnectionString("DbConnetion")));

            services.AddCors(cors => cors.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(

                    name: "Default",
                    pattern: "{controller}/{action}/{id?}"
                    );

                // endpoints.MapControllers();
            });
        }
    }
}
