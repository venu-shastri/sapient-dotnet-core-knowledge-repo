using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public class A
    {
        //public void Operation() { }
    }
    public static class TypeAExtensibilityList
    {
        //Extension Methods
        public static void Operation(this A obj)
        {
            //Do Operation On Obj
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {
   

        }
    }
}
