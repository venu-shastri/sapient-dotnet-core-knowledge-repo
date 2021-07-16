using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOrientation
{
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
            Func<string, bool> predicate = CheckStringLengthGreaterThanGivenArgument(5);
            List<string> projectionResult= SelectQuery(names,predicate);
                projectionResult = SelectQuery(names, CheckStringLengthGreaterThanGivenArgument(4));
             projectionResult = SelectQuery(names, CheckStringLengthGreaterThanGivenArgument(3));
             projectionResult = SelectQuery(names, CheckStringLengthGreaterThanGivenArgument(2));
            //Fluent Interface Pattern
           string item= GenericSelectQuery<string>(names.ToList(), CheckStringLengthGreaterThanGivenArgument(2)).FirstOrDefault();
            // item=  names.GenericSelectQuery(CheckStringLengthGreaterThanGivenArgument(2)).FirstOrDefault();
            System.Linq.Enumerable.Where(names, new Func<string, bool>((string i) => { return i.Length > 5; }));
            
           
        }
        //Pure Function
        //CheckStringLengthGreaterThanFour("Abcde");
        //....n CheckStringLengthGreaterThanFour("Abcde");
       
        static Func<string,bool> CheckStringLengthGreaterThanGivenArgument(int length)
        {
            int x = 100;
            bool ValidateString(string item)
            {
                return item.Length > length+x;
            }
            x = 500;
            return new Func<string, bool>( ValidateString);
        }
        static Func<string, bool> CheckStringLengthLessThanGivenArgument(int length)
        {
            bool ValidateString(string item)
            {
                return item.Length < length;
            }
            return ValidateString;
        }
       
        //Pure Function
        static List<string> SelectQuery(string[] source,Func<string,bool> predicate)
        {
            List<string> projection = new List<string>(); 
            for(int i = 0; i < source.Length; i++)
            {
                if (predicate.Invoke(source[i]))
                {
                    projection.Add(source[i]);
                }
            }
            return projection;
        }

        public static List<TSource> GenericSelectQuery<TSource>(TSource[] source,Func<TSource,bool> predicate)
        {
            List<TSource> projection = new List<TSource>();
            for (int i = 0; i < source.Length; i++)
            {
                if (predicate.Invoke(source[i]))
                {
                    projection.Add(source[i]);
                }
            }
            return projection;
        }
        public static IEnumerable<TSource> GenericSelectQuery<TSource>(IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            List<TSource> projection = new List<TSource>();
            foreach(TSource item in source)
            {
                if (predicate.Invoke(item))
                {
                    projection.Add(item);
                }
            }
            return projection;
        }
        public static TSource SelectFirstOrDefault<TSource>(IEnumerable<TSource> source)
        {
            TSource _item = default(TSource);
            
            foreach (TSource item in source)
            {
                _item = item;
                break;
            }
            return _item;
            
        }
    }
}
