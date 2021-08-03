using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHnadlingDemo.Controllers
{
    
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error()
        {
            //Returns Object Result - RFC 7807
            
            IExceptionHandlerFeature errorFeature = this.ControllerContext.HttpContext.Features.Get<IExceptionHandlerFeature>();
            
            return Problem();
        }

    }
}
