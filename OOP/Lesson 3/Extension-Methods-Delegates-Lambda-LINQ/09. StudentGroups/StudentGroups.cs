using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class StudentGroups
    {
        public static void Print(IEnumerable<Student> collection)
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " +  item.Email);
            }
        }

        static void Main()
        {
            var students = new List<Student>()
            {
                new Student("Albena","Georgieva", 121206, "02-3123-32", "Al.geo@abv.bg", new List<int>() {2, 3, 4, 2}, 1),
                new Student("Georgie","Albenov", 345345, "122343-46-37672", "Geo.Al@ie.va", new List<int>() {2, 2, 2}, 2),
                new Student("Boris","Vasilev", 647606, "02-345123-77", "boris@abv.bg", new List<int>() {6, 6}, 1),
                new Student("Vasil","Borisov", 4564345, "343-97-32", "vasil@bori.sov", new List<int>() {5, 6, 5}, 2),
                new Student("Ivan","Jordanov", 435345345, "02-255476-32", "Iva@Njor.danov", new List<int>() {3, 4}, 1)
            };

            var groups = new List<Group>()
            {
                new Group(1, "Mathematics"), 
                new Group(2, "Chemistry"),
                new Group(3, "Physics")
            };

            //task 09.
            Console.WriteLine("Task 9: Students with group number 2:");
            var studentsFromGroupTwo = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            var studentsFromGroupTwoLINQ =
                from st in students
                where st.GroupNumber == 2
                orderby st.FirstName
                select st;
            Print(studentsFromGroupTwo);
            Console.WriteLine();
            Print(studentsFromGroupTwoLINQ);
            Console.WriteLine();

            //task 10
            Console.WriteLine("Task 10: Extension method to students:");
            var extMethodSortGroup2 = students.SortGroup(2);
            Print(extMethodSortGroup2);
            Console.WriteLine();

            //task 11
            Console.WriteLine("Task 11: Extract students by domain:");
            var extractStudentsbyDomain = students.ExtractByDomain("abv.bg");
            Print(extractStudentsbyDomain);
            Console.WriteLine();

            //task 12
            Console.WriteLine("Task 12: Extract students by phone:");
            var getStudentsInSofia = students.FindPhonesIn("02");
            Print(getStudentsInSofia);
            Console.WriteLine();

            //task 13
            Console.WriteLine("Task 13: Extract students by specific mark:");
            students.GetByMark(6);
            Console.WriteLine();

            //task 14
            Console.WriteLine("Task 14: Extract students by count of marks:");
            students.GetByNumberOfMarks(2);
            Console.WriteLine();

            //task 15
            Console.WriteLine("Task 15: Extract students by year of enrollment:");
            var marksInYear = students.ExtractMarks(2006);
            Print(marksInYear);
            Console.WriteLine();

            //task 16
            Console.WriteLine("Task 16: Students in Math:");
            var studsInMath = students.GetStudentsIn(groups, "Mathematics");
            Print(studsInMath);
            Console.WriteLine();

            //task 18
            Console.WriteLine("Task 18:");
            students.GroupByGroupLINQ();

            //task 19
            Console.WriteLine("Task 19:");
            students.GroupByGroupExtMethods();
        }
    }
}
