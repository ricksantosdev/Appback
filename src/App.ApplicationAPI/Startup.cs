using App.ApplicationCore.Interfaces.Repository;
using App.ApplicationCore.Interfaces.Services;
using App.ApplicationCore.Services;
using App.Infrastructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace App.ApplicationAPI
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
            services.AddTransient<IClientServices, ClientServices>();
            services.AddTransient<IClientRepository, ClientRepository>();
            services.AddTransient<IOrderServices, OrderServices>();
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IProductServices, ProductServices>();
            services.AddTransient<IProductRepository, ProductRepository>();
            services.AddTransient<IProductRepository, ProductRepository>();

            services.AddCors();
            services.AddControllers(
                // options => options.SerializerOptions.WriteIndented = true
                );

            string conexao = Configuration.GetConnectionString("defaultConexao");

            services.AddDbContext<Infrastructure.Data.ApplicationContext>(option => option.UseSqlServer(conexao, b => b.MigrationsAssembly("App.ApplicationAPI")));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "API",
                    Description = "Gateway",
                    TermsOfService = new Uri("https://example.com/license"),
                    Contact = new OpenApiContact
                    {
                        Name = "Ricardo Santos",
                        Email = string.Empty,
                        Url = new Uri("https://example.com/license"),
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Ricardo Santos Corp",
                        Url = new Uri("https://example.com/license"),
                    }
                });
            });

            //services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new  Microsoft.OpenApi.OpenApiFormat  { Title = "Put title here", Description = "DotNet Core Api 3 - with swagger" }); });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
            app.UseCors(option => option.AllowAnyOrigin()
                                .AllowAnyMethod()
                                .AllowAnyHeader()
                                );
            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            app.UseSwagger();


            app.UseSwaggerUI(opt =>
            {
                opt.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
            });
        }
    }
}
