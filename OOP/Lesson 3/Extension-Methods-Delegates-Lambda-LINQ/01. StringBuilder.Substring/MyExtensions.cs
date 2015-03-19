using System;
using System.Text;


namespace StringBuilderSubstring
{
    class MyExtensions
    {
        static void Main()
        {
            
            var builder = new StringBuilder();
            builder.Append("12345");
            Console.WriteLine(builder.Substring(1, 2));
        }
    }
}
