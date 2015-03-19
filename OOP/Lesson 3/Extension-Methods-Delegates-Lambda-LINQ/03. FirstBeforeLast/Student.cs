namespace FirstBeforeLast
{
    using System;

    public class Student
    {
        private string firstname;
        private string lastname;
        private int age;

        public Student(string currentFirstName, string currentLastName, int currentAge)
        {
            this.FirstName = currentFirstName;
            this.LastName = currentLastName;
            this.Age = currentAge;
            
        }

        public string FirstName 
        { 
            get
            {
                return this.firstname;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentNullException("First name must be longer than 0 symbols");
                }

                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }
            set
            {
                if (value.Length <= 0)
                {
                    throw new ArgumentNullException("Last name must be longer than 0 symbols");
                }

                this.lastname = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 5)
                {
                    throw new ArgumentNullException("Students must be older than 5 years");
                }

                this.age = value;
            }
        }
    }
}
