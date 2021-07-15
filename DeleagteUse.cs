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
            Button_Click();
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
