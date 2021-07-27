using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalulcatorApiLib.Services
{
    public class DbWriter : IDbWriter
    {
        IDataOptimizer _optimizer;
        IDataValidator _validator;
        public DbWriter(IDataOptimizer optimizer,IDataValidator validator)
        {
            this._optimizer = optimizer;
            this._validator = validator;
        }
        public void Write() {
            this._validator.Validate();
            this._optimizer.Optimize();
        
        }
    }
}
