using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameterization
{
    public class Thread
    {

        public void Start(ThreadStartDelegate taskAddress)
        {
            taskAddress.Invoke();
           
        }
    }
   public  delegate void ThreadStartDelegate();
  
    class Program
    {
        static void Main(string[] args)
        {
            //  Button_Click();
            Subject _subject = new Subject();
            ObserverOne _observerOne = new ObserverOne();
            ObserverTwo _observerTwo = new ObserverTwo();

            NotificationHandler observerOneAdress = new NotificationHandler(_observerOne.UpdateWhenStateChanged);
            // _subject.Add_StateChanged(observerOneAdress);
            _subject.StateChanged += observerOneAdress;

            NotificationHandler observerTwoAdress = new NotificationHandler(_observerTwo.NotfiyWhenStateChanged);
            //_subject.Add_StateChanged(observerTwoAdress);
            _subject.StateChanged += observerTwoAdress;



            while (true)
            {
                _subject.ChangeState();
                System.Threading.Thread.Sleep(5000);
            }







        }

       static void Button_Click()
        {
            Console.WriteLine("Button Clicked");
            Thread _searchThread = new Thread();
            ThreadStartDelegate _searchTaskAddress = new ThreadStartDelegate(Program.SearchWrapper);
            _searchThread.Start(_searchTaskAddress);

            Thread _updateTaskThread = new Thread();
            ThreadStartDelegate _updateTaskAddress = new ThreadStartDelegate(Program.UpdateTask);
            _updateTaskThread.Start(_updateTaskAddress);

            Thread _deleteTaskThread = new Thread();
            _deleteTaskThread.Start(new ThreadStartDelegate(Program.DeleteTask));
        }
        static void SearchWrapper()
        {
            SearchTask("null");
        }
        static void SearchTask(string searchKey) { }
        static void UpdateTask() { }
        static void DeleteTask() { }

        static void  UpdateUi(string result)
        {

        }
        static void UpdateCallback(bool isUpdateSuccess) { }
        static void DeleteCallback(bool isUpdateSuccess) { }


    }
}
