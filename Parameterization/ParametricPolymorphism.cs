using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterization
{
    

    public class DynamicArray
    {

        //private Data Fields
        private int[] buffer;
        private int itemCount;
        //Constructor
        public DynamicArray(int capacity)
        {
            buffer = new int[capacity];
        }
        //Property
        public int Capacity
        {
            get
            {
                return buffer.Length;
            }
        }
        //Property
        public int ItemCount
        {
            get
            {
                return itemCount;
            }
        }
        //indexer Support
        public int this[int index]
        {
            set
            {
                counter++;
                if (index >= capacity)
                {
                    Array.Resize(ref buffer, index + 5);
                }
                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }
        }
    }

    public class Program
    {
        static void Main()
        {
            DynamicArray _dynamicArray = new DynamicArray(5);
            _dynamicArray[0] = 100;// _dynamicArray.set_Item(0,100);
            _dynamicArray[1] = 200;
            _dynamicArray[2] = 300;
            _dynamicArray[3] = 400;
            _dynamicArray[4] = 500;
            _dynamicArray[5] = 500;
            int value = _dynamicArray[5];//_dynamicArray.get_Item(5);

            System.Console.WriteLine("Number Of Elements in DynamicArray" + _dynamicArray.ItemCount);
            System.Console.WriteLine("DynamicArray Capacity" + _dynamicArray.Capacity);

            int[] numbers = new int[100];// System.Array numbers=new System.Array(100);
            numbers[0] = 100;
        }
    }
}
