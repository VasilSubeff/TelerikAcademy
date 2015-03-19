using System;
using System.Collections.Generic;
using System.Linq;

namespace StringBuilderSubstring
{
    public static class IEnumerableExtensions
    {
        public static decimal SumAll<T>(this IEnumerable<T> collection) where T : struct
        {
            decimal result = 0;

            foreach (var item in collection)
            {
                result += Convert.ToDecimal(item);
            }

            return result;
        }

        public static decimal ProductAll<T>(this IEnumerable<T> collection) where T : struct
        {
            decimal product = 1;

            foreach (var item in collection)
            {
                product *= Convert.ToDecimal(item);
            }
            return product;
        }

        public static T MinOfCollection<T>(this IEnumerable<T> collection) where T : struct, IComparable<T>
        {
            T min = collection.ElementAt(0);

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T MaxOfCollection<T>(this IEnumerable<T> collection) where T : struct, IComparable<T>
        {
            T max = collection.ElementAt(0);

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }


        public static decimal AverageOfCollection<T>(this IEnumerable<T> collection) where T : struct, IComparable<T>
        {
            var sum = collection.SumAll();
            decimal avg = sum / collection.Count();

            return avg;

        }
    }
}
