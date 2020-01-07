using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using corkboard.Models;
using corkboard.Data;

namespace corkboard
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Latest);

            services.AddDbContext<CoursePropsContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("CoursePropsContext")));

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });

            //services.AddServerSideBlazor(); // adds blazor tooling

            services.AddScoped(typeof(IDataRepository<>), typeof(DataRepository<>));

            // In production, the Angular files will be served from this directory
            //services.AddSpaStaticFiles(configuration =>
            //{
            //    configuration.RootPath = "ClientApp/dist";
            //});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Middleware that run before routing. Usually the following appear here:
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

            }

            app.UseStaticFiles();

            // Runs matching. An endpoint is selected and set on the HttpContext if a match is found.
            app.UseRouting();

            // Middleware that run after routing occurs. Usually the following appear here:
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseCors("CorsPolicy");
             // These middleware can take different actions based on the endpoint.

            // Executes the endpoint that was selected by routing.
            app.UseEndpoints(endpoints =>
            {
            // Mapping of endpoints goes here:
            endpoints.MapRazorPages();
            endpoints.MapControllers();
            });

            // Middleware here will only run if nothing was matched.
        }
    }
}
