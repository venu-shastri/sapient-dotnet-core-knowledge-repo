using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyMgmt
{
    class DbWriter
    {
        void Connect(string credentials) { }
        void DissConnect() { }
       public void WriteContent(string content) {
            Connect("");
            //write
            DissConnect();
        
        }
    }
   class DataValidator
    {
        DbWriter _dbwriter = new DbWriter();
        public bool ValidateData()
        {
            _dbwriter.WriteContent("......");
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DataValidator _validatorRef = new DataValidator();
            _validatorRef.ValidateData();
        }
    }

    class ValidatorTestSuite
    {
        public void AssertValidateDataResult()
        {
            DataValidator _dataValidator = new DataValidator();
            bool actualValue=_dataValidator.ValidateData();
            Assert.Equals(false, actualValue);
        }

    }


    public class InternationalSpaceStation
    {
        public void Dock() { 
        
            //Space Vehicle -> Connect()
        }
        public void UnDock() { 
        
        //Space vehice DissConnect()
        }
    }

    public  class NasaSpaceCraft
    {

    }
    public class USSRSpaceCraft
    {

    }
    public class ISROSpaceCraft
    {

    }


}
