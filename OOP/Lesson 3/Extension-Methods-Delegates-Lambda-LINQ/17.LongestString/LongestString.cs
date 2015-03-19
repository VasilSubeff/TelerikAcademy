namespace _17.LongestString
{
    using System;
    using System.Linq;

    class LongestString
    {
        static void Main()
        {
            var arrayOfStrings = new string[10];
            Random randomGen = new Random();


            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                arrayOfStrings[i] = new string('a', randomGen.Next(20));
            }

            var longestString = arrayOfStrings
                .Where(x => x.Length == arrayOfStrings
                    .Max(m => m.Length));

            foreach (var str in longestString)
            {
                Console.WriteLine("{0} : Length {1}", str, str.Length);
            }
        }
    }
}
