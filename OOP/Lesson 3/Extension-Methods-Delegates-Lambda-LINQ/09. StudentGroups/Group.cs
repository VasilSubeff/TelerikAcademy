namespace StudentGroups
{
    using System;
    using System.Linq;
    public class Group
    {
        private int groupNumber;
        private string depName;

        public Group(int gn, string dn)
        {
            this.GroupNumber = gn;
            this.DepartmentName = dn;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid group number");
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.depName;
            }
            set
            {
                if (value.Length == 0)
                {
                    throw new ArgumentException("Invalid dep name");
                }

                this.depName = value;
            }
        }
    }
}
