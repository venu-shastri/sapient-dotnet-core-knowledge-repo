using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.CustomActionResults
{
    public class CsvResult:ActionResult
    {
        //Sysnchronous
        public override void ExecuteResult(ActionContext context)
        {
            // Fill the Response
            //context.HttpContext.Response.Body.
        }
    }
}
