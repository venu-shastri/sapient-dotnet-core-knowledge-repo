using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EMICalculatorLib;

namespace EMICalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EMICalculatorController : ControllerBase
    {
        [HttpGet("{principal}/{tenure}/{interestRate}")]
        public EMIInfo GetEMIDetails(double principal, double tenure, double interestRate)
        {
            var emiDetails = DisplayEMIDetails.CalculateEMIDetails(principal, tenure, interestRate);
            return emiDetails;
        }
       
    }
}
