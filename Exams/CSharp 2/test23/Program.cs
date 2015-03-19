using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3 };
            var target = new int[3];

            Array.Copy(source, target, source.Length);
            source[0] = 0;
            Console.WriteLine(target[0]);
        }
    }
}
