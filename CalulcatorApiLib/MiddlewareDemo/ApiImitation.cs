using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddlewareDemo
{
    public static class ApiImitation
    {
        public static void HandleGet(IApplicationBuilder app)
        {
            app.Run(async context => {

                await context.Response.WriteAsync("Handling Get Request.....");
            });
           
        }

    }
}
