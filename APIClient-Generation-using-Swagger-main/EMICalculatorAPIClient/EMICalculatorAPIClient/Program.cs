using System;

namespace EMICalculatorAPIClient
{

   
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new EMICalculatorClient();
            var emiDetails = await client.GetEMIDetailsAsync(10000, 24, 14);

            // System.IO.StreamReader _reader = new System.IO.StreamReader(emiDetails.Stream);
            //Console.WriteLine( _reader.ReadToEnd());


            System.Runtime.Serialization.Json.DataContractJsonSerializer _serializer = new

                System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(DataModelsLib.EMIInfo));

            DataModelsLib.EMIInfo _testObject = _serializer.ReadObject(emiDetails.Stream) as DataModelsLib.EMIInfo;

            Console.Write(_testObject.ToString());

        }
    }
}
