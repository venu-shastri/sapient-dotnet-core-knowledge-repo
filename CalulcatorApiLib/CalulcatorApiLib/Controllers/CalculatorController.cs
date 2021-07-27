using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.Controllers
{
    //URL - http://origin/api/Calculator
    //Action : GET


    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        ILogger<CalculatorController> _logger;
        public CalculatorController(Services.IDbWriter writer, ILogger<CalculatorController> logger)
        {
            this._logger = logger;

        }
        [HttpGet]
        public string GetResult()
        {
            this._logger.LogInformation($"{nameof(GetResult)} called");
            return "Sum of .....";
        }
        [HttpGet]
        public string GetNextResult()
        {
            return "Next Result...";
        }
        [HttpPost]
        public int Add(int x,int y)
        {
            return x + y;
        }
        [HttpPost]
        public int Sub(int x, int y)
        {
            return x + y;
        }
    }
}
