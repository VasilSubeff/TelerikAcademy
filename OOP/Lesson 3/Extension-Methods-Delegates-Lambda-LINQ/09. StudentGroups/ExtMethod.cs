using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public static class ExtMethod
    {
        public static IEnumerable<Student> SortGroup(this IEnumerable<Student> st, int group)
        {
            var studentsFromGroupTwo = st
                .Where(x => x.GroupNumber == group)
                .OrderBy(x => x.FirstName);
            return studentsFromGroupTwo;
        }

        public static IEnumerable<Student> ExtractByDomain(this IEnumerable<Student> students, string domain)
        {
            var studentsByDomain = students
                .Where(
                        x => x.Email
                            .Substring(x.Email.IndexOf("@") + 1)
                        == domain);
            return studentsByDomain;
        }

        public static IEnumerable<Student> FindPhonesIn(this IEnumerable<Student> students, string cityCode)
        {
            var studentsInTown = students
                .Where(x => x.Telephone
                    .Substring(0, cityCode.Length) == cityCode);
            return studentsInTown;
        }
        
        public static void GetByMark(this IEnumerable<Student> students, int mark)
        {
            var studentsByMark =
                from st in students
                where st.Mark.Contains(mark)
                select new
                {
                    Fullname = st.FirstName + " " + st.LastName,
                    Marks = st.Mark
                };

            var result = new List<string>();

            foreach (var stud in studentsByMark)
            {
                Console.WriteLine("{0}: {1}", stud.Fullname, string.Join(",", stud.Marks));
            } 
        }

        public static void GetByNumberOfMarks(this IEnumerable<Student> students, int count)
        {
            var studentsByNMarks = students
                .Where(x => x.Mark.Count == count)
                .Select(st => new 
                {
                    Fullname = st.FirstName + " " + st.LastName,
                    Marks = st.Mark
                });

            var result = new List<string>();

            foreach (var stud in studentsByNMarks)
            {
                Console.WriteLine("{0}: {1}", stud.Fullname, string.Join(",", stud.Marks));
            } 
        }

        public static IEnumerable<Student> ExtractMarks(this IEnumerable<Student> students, int fullYear)
        {

            string year = fullYear.ToString().Substring(2, 2);

            var marksInYear = students
                .Where(x => x.FN.ToString().Substring(4, 2) == year);

            return marksInYear;
        }

        public static IEnumerable<Student> GetStudentsIn(this IEnumerable<Student> students, List<Group> groups, string currentGroup)
        {
            var studsInMath =
                from g in groups
                where g.DepartmentName == currentGroup
                join st in students on g.GroupNumber equals st.GroupNumber
                select st;

            return studsInMath;
        }
    }
}
