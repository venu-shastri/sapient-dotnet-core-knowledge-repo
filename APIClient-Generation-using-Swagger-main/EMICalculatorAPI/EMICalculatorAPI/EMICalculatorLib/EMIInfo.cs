using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMICalculatorLib
{
    public class EMIInfo
    {
        public double emiValue { get; set; }
        public double payableAmount { get; set; }
        public double interestAmount { get; set; }

        override
            public string ToString()
        {
            return $"EMI Value : {this.emiValue}\nTotal Interest : {this.interestAmount}\nTotal Payable Amount : {this.payableAmount}";   
        }
    }
}
