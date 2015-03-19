using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class GenericListMain
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>(4);

            list.Add(10);
            list.Add(5);
            list.Add(2);
            list.Add(3);
            list.Add(2);
            list.Add(19);
            list.Add(7);
            list.Add(4);
            

            //var indexTest = list.GetAt(2);
            //Console.WriteLine(indexTest);

            //var removeTest = list.RemoveAt(3);
            //Console.WriteLine(removeTest);
            //var indexTest2 = list.GetAt(3);
            //Console.WriteLine(indexTest2);

            list.InsertAt(101, 1);
            //Console.WriteLine(list.GetAt(6));

            //list.Clear();
            //Console.WriteLine(list.GetAt(2));

            var index = list.Find(1);
            Console.WriteLine(index);
            Console.WriteLine(list.ToString());

            Console.WriteLine(list.Max());
            Console.WriteLine(list.Min());
            

        }
    }
}
