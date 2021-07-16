
    public delegate void NotificationHandler(string state);
   public  class Subject
    {
        string state;
        // List<NotificationHandler> observers = new List<NotificationHandler>();
        NotificationHandler StateChanged = null;
        public void ChangeState()
        {
            state = $"State: {new Random().Next()}";
            NotifyAllObservers();

        }

        //Event Hooks
        //Subscribe
        public void Add_StateChanged(NotificationHandler observerAddress) {

            //System.Delegate.Combine(params Delegate[]);
            // this.StateChanged = System.Delegate.Combine(this.StateChanged,observerAddress) as NotificationHandler;
            this.StateChanged += observerAddress;
                
        }
        //UnSubscribe
        public void Remove_StateChanged(NotificationHandler observerAddress) {


            //            this.StateChanged = System.Delegate.Remove(this.StateChanged, observerAddress) as NotificationHandler;
            this.StateChanged -= observerAddress;

            
        }

        void NotifyAllObservers()
        {
            //for(int i = 0; i < observers.Count; i++)
            //{
            //    observers[i].Invoke(this.state);
            //}
            this.StateChanged.Invoke(this.state);
        }
    }

    public class ObserverOne {
    
        public void UpdateWhenStateChanged(string state)
        {
            Console.WriteLine($"ObserverOne Subject State Changed {state} ");
        }
    
    }

    public class ObserverTwo
    {
        public void NotfiyWhenStateChanged(string state)
        {
            Console.WriteLine($"ObserverTwo Subject State Changed {state} ");
        }

    }
    
class Program
    {
        static void Main(string[] args)
        {
            //  Button_Click();
            Subject _subject = new Subject();
            ObserverOne _observerOne = new ObserverOne();
            ObserverTwo _observerTwo = new ObserverTwo();

            NotificationHandler observerOneAdress = new NotificationHandler(_observerOne.UpdateWhenStateChanged);
            _subject.Add_StateChanged(observerOneAdress);

            NotificationHandler observerTwoAdress = new NotificationHandler(_observerTwo.NotfiyWhenStateChanged);
            _subject.Add_StateChanged(observerTwoAdress);



            while (true)
            {
                _subject.ChangeState();
                System.Threading.Thread.Sleep(5000);
            }
         }
     }
         
