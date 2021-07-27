using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RemoteApiController : ControllerBase
    {
        Models.RemoteServiceOptions _remoteServiceSectionObject;
        public RemoteApiController(IOptions<Models.RemoteServiceOptions> remoteServiceSectionObject)
        {
            this._remoteServiceSectionObject = remoteServiceSectionObject.Value;
        }

        [HttpGet]
        public string Get()
        {
            return $"{_remoteServiceSectionObject.Address}," +
                $"{_remoteServiceSectionObject.Timeout}," +
                $"{_remoteServiceSectionObject.RequiredSecureChannel.ToString()}"; 

        }
    }
}
