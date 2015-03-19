using System;
using System.Collections.Generic;
using System.Linq;


namespace DivisibleBy3And7
{
    class DivisibleBy3And7
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[150];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            Console.WriteLine("Lambex");
            var result = numbers.Where(x => x % 3 == 0 && x % 7 == 0);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("LINQ");
            var resultLINQ =
                from num in numbers
                where num % 3 == 0 && num % 7 == 0
                select num;

            foreach (var item in resultLINQ)
            {
                Console.WriteLine(item);
            }
        }
    }
}
