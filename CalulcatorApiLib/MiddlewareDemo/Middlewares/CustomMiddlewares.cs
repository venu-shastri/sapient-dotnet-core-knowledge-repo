using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo.Middlewares
{
    public static class CustomMiddlewares
    {
        public static void UseCustomMidlleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) => {

                await context.Response.WriteAsync("Hello From Use Middleware ");
                await next.Invoke();
                await context.Response.WriteAsync("Bye From Use Middleware ");

            });
        }
        public static void UseTerminalMidlleware(this IApplicationBuilder app)
        {
            //terminal middleware
            app.Run(async context => {
                await context.Response.WriteAsync("Hello World!");

            });

        }
    }
}
