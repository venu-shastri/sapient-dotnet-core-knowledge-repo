using System;

namespace Async_Demo
{
    class Program
    {
        static void Main_old(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Task();
            // System.Threading.Thread _threadObj = 
            //  new System.Threading.Thread(new System.Threading.ThreadStart(Program.Task));
            //_threadObj.Start();
            System.Collections.Generic.Dictionary<string, object> _dataBag =
                new System.Collections.Generic.Dictionary<string, object>();

            _dataBag.Add("callbackAddress",new Action(()=> {
                Console.WriteLine("Async Task Completed");
                Console.WriteLine(_dataBag["result"].ToString());
            
            }));
            System.Threading.ThreadPool.QueueUserWorkItem(
                new System.Threading.WaitCallback(Program.TestWrapper),_dataBag);
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => {  byte[] cipher=Encrypt(obj as string); },new object());
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => { string digest = Hash(obj as string); }, new object()); ;
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => { GenerateSignature(obj as string); }, new object()) ;

            //Chain Async Tasks

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Main in Execution {i} and  Executed by {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                System.Threading.Thread.Sleep(2000); if (i == 5) { 
                
                    //I would like to cancel Async-operation
                }
            }
        }

        static void TestWrapper(object input)
        {
            System.Collections.Generic.Dictionary<string,object> _dataBag=input as System.Collections.Generic.Dictionary<string, object>;
            int result=Task();
            _dataBag.Add("result", result);
            (_dataBag["callbackAddress"] as Action).Invoke();
        }

        static int Task()
        {
            int sum = 0;
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Task in Execution {i} and Executed by {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                System.Threading.Thread.Sleep(2000);
                sum += i;
                if (i == 4) { throw new Exception("Task Exception"); }
            }
            return sum;
        }
        static byte[] Encrypt(string content)
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Encrypt Task in Execution {i} and Executed by {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                System.Threading.Thread.Sleep(2000);
                
            }
            return new byte[] { 1, 2, 3, 4, 5, 5 };
            
        }
        static  string  Hash(string message)
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Hash Task in Execution {i} and Executed by {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                
            }
            return message;

        }

        static void GenerateSignature(string content)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Generate Signature Task in Execution {i} and Executed by {System.Threading.Thread.CurrentThread.ManagedThreadId}");
                System.Threading.Thread.Sleep(2000);

            }
            
        }

        static void ProcessEducationLoanTask()
        {
            Console.WriteLine("Processing Education Loan Documents");
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => { DocumentOrCertificateVerificationTask(); });
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => { GetApprovalFromUniversityTask(); });
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => { VerifyAssurityTask(); });
        }
        static void DocumentOrCertificateVerificationTask() {

            for (int i=0; i < 10; i++)
            {
                Console.WriteLine("DocumentOrCertificateVerificationTask in Progress....");
                System.Threading.Thread.Sleep(1000);

            }
        }

        static void GetApprovalFromUniversityTask() {


            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("GetApprovalFromUniversityTask in Progress....");
                System.Threading.Thread.Sleep(1000);

            }
        }

        static void VerifyAssurityTask() {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("VerifyAssurityTask in Progress....");
                System.Threading.Thread.Sleep(1000);

            }
        }


    }
}
