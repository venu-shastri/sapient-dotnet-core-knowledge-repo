using System;
using System.Threading.Tasks;

namespace AsyncBreakfast
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Main Thread Id  {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            TestAwaitStatement();
            while (true)
            {
                Console.WriteLine("Main......");
                Task.Delay(1000).Wait();
            }


        }
        static async void TestAwaitStatement()
        {
            Console.WriteLine($"Statement Ahead of await {System.Threading.Thread.CurrentThread.ManagedThreadId}");
            await FryEggsAsync(2);
            while (true)
            {
                Console.WriteLine("TestAwaitStatement......");
                Task.Delay(1000).Wait();
            }
        }

        static void PrepareBreakfast()
        {

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        static void PrepareBreakfastAsync_v1()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggTaskRef = FryEggsAsync(2);
            eggTaskRef.Wait();
            Egg eggs = eggTaskRef.Result;
            Console.WriteLine("eggs are ready");

            Task<Bacon> baconTask = FryBaconAsync(3);
            baconTask.Wait();
            Bacon bacon = baconTask.Result;
            Console.WriteLine("bacon is ready");

            Task<Toast> toastTask = ToastBreadAsync(2);
            toastTask.Wait();
            Toast toast = toastTask.Result;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }
        static async void PrepareBreakfastAsync_v1_UsingAsyncAndAwait()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

             Egg egg= await FryEggsAsync(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon =await FryBaconAsync(3);
            Console.WriteLine("bacon is ready");

            Toast toast =await  ToastBreadAsync(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }
        static void PrepareBreakfastAsync_v2()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggTaskRef = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = ToastBreadAsync(2);

           Task.WaitAll(eggTaskRef,baconTask,toastTask);
            Egg eggs = eggTaskRef.Result;
            Console.WriteLine("eggs are ready");

            Bacon bacon = baconTask.Result;
            Console.WriteLine("bacon is ready");

            Toast toast = toastTask.Result;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }
        static async void PrepareBreakfastAsync_v2_usingAsyncAwait()
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Task<Egg> eggTaskRef = FryEggsAsync(2);
            Task<Bacon> baconTask = FryBaconAsync(3);
            Task<Toast> toastTask = ToastBreadAsync(2);

            //Task.WaitAll(eggTaskRef, baconTask, toastTask);


            Egg eggs = await eggTaskRef;
            Console.WriteLine("eggs are ready");

            Bacon bacon = await baconTask;
            Console.WriteLine("bacon is ready");

            Toast toast = await toastTask;
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }


        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        private static void ApplyJam(Toast toast) =>
            Console.WriteLine("Putting jam on the toast");

        private static void ApplyButter(Toast toast) =>
            Console.WriteLine("Putting butter on the toast");

        private static Toast ToastBread(int slices)
        {
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }
            Console.WriteLine("Start toasting...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        private static Task<Toast> ToastBreadAsync(int slices)
        {
            Task<Toast> _getToastTask = new Task<Toast>(() => {

                Toast _toast=ToastBread(slices);
                return _toast;

            });
            _getToastTask.Start();
            return _getToastTask;
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(3000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }
        private static Task<Bacon> FryBaconAsync(int slices)
        {
            return Task.Factory.StartNew<Bacon>(() => {

                return FryBacon(slices);
            
            });

        }
        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");

            return new Egg();
        }

        private static Task<Egg> FryEggsAsync(int howMany)
        {
            return Task.Factory.StartNew<Egg>(() => {

                return FryEggs(howMany);
            });
        }

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}