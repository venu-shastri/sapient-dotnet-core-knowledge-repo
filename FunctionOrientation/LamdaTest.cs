using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrientation
{
    class LamdaTest
    {
        Action Test(int arg)
        {
            string lVar = "ffff";
            //void method(){}
            // new Action(method);
            Action obj  = () => { Console.WriteLine($"{arg} + {lVar}"); }; // Generate Target Function , instantiate Delegate Object
            Action newObj = new Action(Target);
            //C# 7.0
            void Target()
            {
                Console.WriteLine($"{arg} + {lVar}");
            }
            //return newObj;
            //return obj;
            return Target;
        }
      
    }
}
