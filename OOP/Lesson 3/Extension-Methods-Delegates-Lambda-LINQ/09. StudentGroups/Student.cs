using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGroups
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int FN { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public List<int> Mark { get; set; }
        public int GroupNumber { get; set; }

        public Student(string fname, string ln, int fNumber, string tel, string emailAdd, List<int> allMarks, int GN)
        {
            this.FirstName = fname;
            this.LastName = ln;
            this.FN = fNumber;
            this.Telephone = tel;
            this.Email = emailAdd; 
            this.Mark = allMarks;
            this.GroupNumber = GN;
        }
    }
}
