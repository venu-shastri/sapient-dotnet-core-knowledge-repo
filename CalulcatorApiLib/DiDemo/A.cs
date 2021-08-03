using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiDemo
{
    public class A
    {
        IB _obj;
        public A(IB obj) {

            this._obj = obj;
        }
    }
}
