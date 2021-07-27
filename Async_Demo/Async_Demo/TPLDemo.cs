using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;//TPL

namespace Async_Demo
{
    public class TPLDemo
    {
       static void Main_new()
        {
            Task _task1 = new Task(new Action(Print)); // new Task(Task1); , new Task(()=>{});
            Task _task2 = new Task(Insert, "argument");
            Task<string> _task3 = new Task<string>(DownloadFile);
            Task<string> _task4 = new Task<string>(GetDataFromServer, "argument");
            Task _task5=Task.Factory.StartNew(() => { 
            
                for(int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Factory Task");
                }
            
            });

            _task1.Start();
            _task2.Start();
            _task3.Start();
            _task4.Start();


            //Task.WaitAll(_task1, _task2, _task3, _task4);
            Task.WaitAny(_task1, _task2, _task3, _task4);

        }

        static void Print() { 
        
        for(int i = 0; i < 10; i++) { Console.WriteLine("Print.......");Task.Delay(1000); }
        }
        static void Insert(object obj) { for (int i = 0; i < 10; i++) { Console.WriteLine("Insert......."); Task.Delay(1000); } }

        static string DownloadFile() { for (int i = 0; i < 10; i++) { Console.WriteLine("DownloadFile......."); Task.Delay(1000); } return "Task3 Completed"; }

        static string GetDataFromServer(object obj) {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("GetDataFromServer.......");
                Task.Delay(1000);
            }
            return "task4 Completed";  }


    }
}
