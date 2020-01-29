using System;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using Microsoft.OpenApi.Models;
using PMM.DataAccess.Repositories;
using PMM.Service.Services;
using Swashbuckle.AspNetCore.Swagger;

namespace PersonalMovieManagement
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // Register the Swagger generator
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new Info
                    {
                        Version = "v1", Title = "Kyle's API", Description = "Initialize the Movies endpoint",
                        TermsOfService = new Uri($"https://example.com/terms").ToString(),
                        Contact = new Contact
                        {
                            Name = "Kyle Zhao", Email = "kyle.zhao2011@gmail.com",
                            Url = new Uri($"https://github.com/").ToString()
                        },
                        License = new License
                        {
                            Name = "Sample License",
                            Url = "Sample URL"
                        }
                    });

                // Set comments path, without the path set up the elements added to the controller will not be shown.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
            var connectionString = Configuration.GetSection("ConnectionString").Value;
            var connection = new SqlConnection(connectionString);
            services.AddTransient<IDbProvider>(d => new DbProvider(connection));

            // Inject Repositories
            services.AddSingleton<IMovieRepository, MovieRepository>();

            // Inject Services
            services.AddSingleton<IMovieService, MovieService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c => { c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API v1"); });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}