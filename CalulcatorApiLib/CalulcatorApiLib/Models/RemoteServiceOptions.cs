using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.Models
{
    /*
     * 
     * RemoteService": {
    "address": "http://localhost:9000",
    "timeout": "10s",
    "requiredSecureChannel": false
  }
     */
    public class RemoteServiceOptions
    {
        public static string SectionName = "RemoteService";
        public string Address { get; set; }
        public string Timeout { get; set; }
        public Boolean RequiredSecureChannel { get; set; }
    }
}
