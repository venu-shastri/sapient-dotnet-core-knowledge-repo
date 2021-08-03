using System;
using System.Threading.Tasks;

namespace ThreadingModeSample
{
    class Program
    {
        static void Main_old(string[] args)
        {
            Console.WriteLine($"Is Main Thread Excecution Mode is Background {System.Threading.Thread.CurrentThread.IsBackground}");
            new System.Threading.Thread(() => { 
            
            for(int i = 0; i <10 ; i++)
                {
                    Console.WriteLine($"Is Explict Thread Excecution Mode is Background {System.Threading.Thread.CurrentThread.IsBackground}");
                    System.Threading.Thread.Sleep(2000);
                }
                Console.WriteLine("Explicit Thread Completed");

            }).Start();
            System.Threading.ThreadPool.QueueUserWorkItem((obj) => {

                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"Is Thread Pool Thread Excecution Mode is Background {System.Threading.Thread.CurrentThread.IsBackground}");
                    System.Threading.Thread.Sleep(2000);
                }
                Console.WriteLine("ThreadPool Thread  Completed");

            });

            Console.WriteLine("Main Completed");
        }

        static void Main()
        {
            Console.WriteLine($"Is Main Thread Excecution Mode is Background {System.Threading.Thread.CurrentThread.IsBackground}");
            //            startTasks();
            AsyncstartTasks();
            Task.Delay(2000).Wait();
            Console.WriteLine("Main Completed");
            
        }

       static   void startTasks()
        {
           Task _t1= Task.Factory.StartNew(() => { Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
           Task _t2= Task.Factory.StartNew(() => { Reuse(); Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
           Task _t3= Task.Factory.StartNew(() => { Reuse(); Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
          Task _t4=  Task.Factory.StartNew(() => { Reuse(); Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
            Task.WaitAll(_t1, _t2, _t3,_t4);
        }
        static async  void AsyncstartTasks()
        {
            Task _t1 = Task.Factory.StartNew(() => { Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
            Task _t2 = Task.Factory.StartNew(() => { Reuse(); Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
            Task _t3 = Task.Factory.StartNew(() => { Reuse(); Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
            Task _t4 = Task.Factory.StartNew(() => { Reuse(); Console.WriteLine($"{System.Threading.Thread.CurrentThread.ManagedThreadId} Completed Task"); });
            await _t1;
            Task.WaitAll(_t2, _t3, _t4);
           
        }
        static void Reuse()
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Thread {System.Threading.Thread.CurrentThread.ManagedThreadId} From Pool Thread Excecution Mode is Background {System.Threading.Thread.CurrentThread.IsBackground}");
                System.Threading.Thread.Sleep(2000);
            }
         
        }
    }
}
