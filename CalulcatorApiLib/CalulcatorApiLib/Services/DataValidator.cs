using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.Services
{
    public class DataValidator : IDataValidator
    {
        IDataLogger _logger;
        public DataValidator(IDataLogger logger)
        {
            this._logger = logger;
        }
        public void Validate() {

            this._logger.WriteLog();
        }
    }
}
