using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;
using ToDo.Application.Profiles;
using ToDo.EntityFrameworkCore;

namespace ToDo.CoreWebApp
{
    public class Startup
    {
        #region [-Ctor-]
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        #endregion

        #region [-Prop-]
        public IConfiguration Configuration { get; }
        #endregion

        #region [-ConfigureServices(IServiceCollection services)-]
        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            #region [-AddRazorPages()-]
            services.AddRazorPages();

            #endregion

            #region [- AddMvcCore() -]
            services.AddMvcCore().AddApiExplorer();
            #endregion

            #region [-AddControllers()-]
            services.AddControllers();

            #endregion

            #region [-Swagger()-]
            //services.AddSwaggerGen(c =>
            //{
            //    c.SwaggerDoc("v1", new OpenApiInfo { Title = "ToDo.WebAPI", Version = "v1" });
            //});
            #endregion

            #region [-AddDbContextPool()-]
            services.AddDbContextPool<ToDoDbContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("LocalConnection"));
            });

            #endregion

            #region [- AddAutoMapper() -]
            services.AddAutoMapper(typeof(Startup));

            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new AutoMapperProfile());
            }).CreateMapper();

            services.AddSingleton(mappingConfig);

            #endregion

            #region [-TanvirArjelAttribute-]
            services.AddServicesOfAllTypes();

            services.AddServicesWithAttributeOfType<ScopedServiceAttribute>();
            #endregion

        }
        #endregion

        #region [-Configure(IApplicationBuilder app, IWebHostEnvironment env)-]
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
        #endregion


    }
}
