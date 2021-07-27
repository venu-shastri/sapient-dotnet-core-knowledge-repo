using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib
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

            services.AddControllers();
            services.AddTransient(typeof(Services.IDbWriter), typeof(Services.DbWriter));
            services.AddTransient(typeof(Services.IDataOptimizer), typeof(Services.DataOptimizer));
            services.AddSingleton(typeof(Services.IDataValidator), typeof(Services.DataValidator));
            services.AddSingleton(typeof(Services.IDataLogger), typeof(Services.DataLogger));
            services.Configure<Models.RemoteServiceOptions>(Configuration.GetSection(Models.RemoteServiceOptions.SectionName));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

           // app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();//Attributed Routing 
            });
        }
    }
}
