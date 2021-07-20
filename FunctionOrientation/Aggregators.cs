using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrientation
{
    public class Employee { }

    //Iterator Design Pattern
    public class EmployeeList:IEnumerable<Employee>
    {
        Employee[] employees = new Employee[1000];

        public IEnumerator<Employee> GetEnumerator()
        {
            return new EmployeeListIterator();
            
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        private class EmployeeListIterator : IEnumerator<Employee>
        {
            public Employee Current => throw new NotImplementedException();

            object IEnumerator.Current => throw new NotImplementedException();

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }

   class TestAggreegator
    {
        //Array,List....Any Aggregator : IEnumerable
        static void Iterate(IEnumerable<Employee> aggregator)
        {
            foreach (Employee item in aggregator) {
            
            }
            /*
            IEnumerator<Employee> iterator = aggregator.GetEnumerator();
            try
            {
             
                while (iterator.MoveNext())
                {
                   Empoylee item= iterator.Current;
                }
            }
            finally
            {
                iterator.Dispose();
            }*/

        }
    }
}
