using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExceptionHnadlingDemo.Filters
{
    public class HttpResponseExceptionFilter : IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Exception!=null)
            {
                context.Result = new ObjectResult(context.Exception.Message) { StatusCode = 500 };
            }
            context.ExceptionHandled = true;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
          
      
        }
    }
}
