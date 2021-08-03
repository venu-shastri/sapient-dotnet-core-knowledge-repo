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

namespace DiDemo
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
            /* //services.AddSingleton<B>();
             * services.Configure<CreditCardDatabaseOptions>(
              Configuration.GetSection(CreditCardDatabaseOptions.SectionName));

              services.AddSingleton<ICreditCardDatabaseSettings>(sp =>
                  sp.GetRequiredService<IOptions<CreditCardDatabaseOptions>>().Value);

              services.AddSingleton<CreditCardService>();

            CreditCardService->A
            ICreditCardDatabaseSettings -> IB
            CreditCardDatabaseOptions ->B
            */


            services.AddControllers();
            //services.AddSingleton<A>();
            //services.AddSingleton<IB>(container => container.GetRequiredService<B>());
            //services.AddSingleton<B>();//One Instance
            //services.AddScoped<A>(); //Per HttpRequest
            //services.AddTransient<A>(); // Per Client Request
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

            }


            app.UseRouting();

           
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
