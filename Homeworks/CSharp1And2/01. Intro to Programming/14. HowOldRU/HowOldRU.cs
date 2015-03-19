using System;

class HowOldRU
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your BD (MM/dd/yyyy) :");
        DateTime birthday = Convert.ToDateTime(Console.ReadLine());
        DateTime currentDate = DateTime.Today;
        Console.WriteLine(currentDate.Year - birthday.Year - 1);
    }
}

