using System;

namespace ORMDemoUsingEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Dispose Block
           using(var db=new CardManagementContext())
            {
                Console.WriteLine($"{db.dbFileName}");
                db.CreditCards.Add(new Models.CreditCard
                { CardHoldeName = "Venu",
                    CardNumber = "123456789", 
                    CreditCardId = new Random().Next(2,1000), CVV = 123, ExpireDate = "28-6-2025", CardType="Visa" });
                db.SaveChanges();

                foreach(var card in db.CreditCards)
                {
                    Console.WriteLine($"{card.CreditCardId},{card.CardHoldeName},{card.CardType}");
                }
            }

          /*  var db = new CardManagementContext();
            try
            {

            }
            finally
            {
                if(db is IDisposable)
                {
                    db.Dispose();
                    db = null;
                }
            }*/
            

        }
    }
}
