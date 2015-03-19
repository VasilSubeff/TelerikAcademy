using System;

class PrintFirstAndLastName
{
    static void Main()
    {
        Console.Write("Enter First Name: ");
        string firstName = Console.ReadLine();
        Console.Write("Enter Last Name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Your name is " + firstName + " " + lastName);
    }
}


