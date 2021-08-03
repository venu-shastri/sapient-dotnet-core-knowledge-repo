using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        A _obj;
        public TestController(A obj) {
            this._obj = obj;
        }
        [HttpGet]
        public string Get() {
            return "test";
        }
    }
}
