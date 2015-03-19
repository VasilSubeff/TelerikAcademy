using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBeforeLast
{
    class FirstBeforeLast
    {
        public static void Print(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName);
            }
        }
        static void Main()
        {
            var students = new List<Student>
            {
                new Student("Albena","Georgieva", 12),
                new Student("Georgie","Albenov", 20),
                new Student("Boris","Vasilev", 15),
                new Student("Vasil","Borisov", 25),
                new Student("Ivan","Jordanov", 18)
            };

            Console.WriteLine("Task 3--------------------------------------");
            var task3 = students.Where(x => x.FirstName.CompareTo(x.LastName) < 0);
            Print(task3);
            Console.WriteLine();

            Console.WriteLine("Native LINQ");
            var task3nativeLINQ =
                from st in students
                where st.FirstName.CompareTo(st.LastName) < 0
                select st;
            Print(task3nativeLINQ);

            Console.WriteLine("Task 4--------------------------------------");
            var task4 = students.Where(x => x.Age >= 18 && x.Age <= 25);
            Print(task4);
            Console.WriteLine();

            Console.WriteLine("Native LINQ");
            var task4nativeLINQ =
                from st in students
                where st.Age >= 18 && st.Age <= 25
                select st;
            Print(task4nativeLINQ);



            Console.WriteLine("Task 5--------------------------------------");
            var task5 = students.OrderByDescending(x => x.FirstName).ThenByDescending(x => x.LastName);
            Print(task5);
            Console.WriteLine();

            Console.WriteLine("Native LINQ");
            var task5NativeLINQ =
                from st in students
                orderby st.FirstName descending, st.LastName descending
                select st;
            Print(task5NativeLINQ);
            
        }
    }
}
