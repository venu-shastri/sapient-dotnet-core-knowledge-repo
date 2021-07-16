class Program
    {
        static void Main(string[] args)
        {
            // "select * from names where name.Length>4";
            //"select <project> from  cities where city Like% "BLR"
            string[] names = { "Sap", "Sapient", "Infy", "Wipro" };
            List<string> result = new List<string>();
            //Loop  -> Iterate
            for(int i = 0; i < names.Length; i++)
            {
                //Condition -> Predicate
                if(names[i].Length > 4)
                {
                    result.Add(names[i]);
                }
            }
                                    //Applying function
   List<string> projectionResult= SelectQuery(names, new Func<string, bool>(Program.CheckStringLengthGreaterThanFour));

        }
        //Pure Function
        //CheckStringLengthGreaterThanFour("Abcde");
        //....n CheckStringLengthGreaterThanFour("Abcde");
        static bool CheckStringLengthGreaterThanFour(string item)
        {
            return item.Length > 4;
        }
        static bool CheckStringLengthLessThanFive(string item)
        {
            return item.Length < 5;
        }
        static bool CheckStringLengthLessThanTwo(string item)
        {
            return item.Length < 2;
        }
        static bool CheckStringLength(string item,int length)
        {
            return item.Length > length;
        }
        int Add(int x, int y) { return x + y + new Random().Next(); };
        //Pure Function
        static List<string> SelectQuery(string[] source,Func<string,int,bool> predicate)
        {
            List<string> projection = new List<string>(); 
            for(int i = 0; i < source.Length; i++)
            {
                if (predicate.Invoke(source[i],))
                {
                    projection.Add(source[i]);
                }
            }
            return projection;
        }
    }
