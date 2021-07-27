using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DITestController : ControllerBase
    {
        Services.IDbWriter _writer;
        IConfigurationRoot _configuration;
        //State the need
        public DITestController(Services.IDbWriter writer,IConfiguration configuration)
        {                   //Object Composition
                            //this._writer = new Services.DbWriter(
                            //  new Services.DataOptimizer(),
                            // new Services.DataValidator(new Services.DataLogger()));
            this._configuration = configuration as IConfigurationRoot;
        }

        [HttpGet]
        public string Get()
        {
            //string str = "";
            //foreach (var provider in _configuration.Providers.ToList())
            //{
            //    str += provider.ToString() + "\n";
            //}

            var myKeyValue = _configuration["MyKey"];
            var title = _configuration["Position:Title"];
            var name = _configuration["Position:Name"];
            var defaultLogLevel = _configuration["Logging:LogLevel:Default"];


            return $"MyKey value: {myKeyValue} \n" +
                           $"Title: {title} \n" +
                           $"Name: {name} \n" +
                           $"Default Log Level: {defaultLogLevel}";

            
        }
    }
}
