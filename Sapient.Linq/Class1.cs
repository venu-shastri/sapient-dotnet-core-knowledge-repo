using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sapient.Linq
{
    public static class Enumerable
    {
        public static IEnumerable<TSource> GenericSelectQuery<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            List<TSource> projection = new List<TSource>();
            foreach (TSource item in source)
            {
                if (predicate.Invoke(item))
                {
                    projection.Add(item);
                }
            }
            return projection;
        }
        public static TSource SelectFirstOrDefault<TSource>(this IEnumerable<TSource> source)
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
