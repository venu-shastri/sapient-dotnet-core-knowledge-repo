using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib
{
    public class Customer
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
    [Route("api/[controller]")]
    [ApiController]
    public class ActionResultTestController : ControllerBase
    {
        [Route("customer/type")]
        public Customer GetCutsomer()
        {
            return new Customer { Id = "C1000", Name = "Tom" };
                 
        }
        [Route("customer/iactionresult")]
        public IActionResult GetCustomerReturnUsingIActionResult()
        {
            return new JsonResult(new Customer { Id = "C100", Name = "Tom" });
        }
        [Route("customer/actionresult")]
        public ActionResult<Customer> GetCustomerReturnUsingActionResult()
        {
            return new JsonResult(new Customer { Id = "C100", Name = "Tom" });
          
        }
       
    }
}
