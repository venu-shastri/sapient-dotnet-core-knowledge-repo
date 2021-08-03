using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace DiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewTestController : ControllerBase
    {
        IServiceProvider _container;
        public NewTestController(IServiceProvider container)
        {
            this._container = container;
            this._container.GetRequiredService<A>();
            
          
        }
        [HttpGet("{data}")]
        public string Action(string data)
        {

            if (data == "hi")
            {
               throw new ArgumentException("Invalid Argument for data");
            }
            return data.ToUpper();
        }
    }
}
