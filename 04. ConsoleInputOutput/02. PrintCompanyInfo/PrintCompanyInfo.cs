//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInfo
{
    static void Main()
    {
        string[] program = { "Company name", "Company address", "Phone number", "Fax number", "Web site", "Manager first name", "Manager last name", "Manager age", "Manager phone" };
        string[] user = new string[program.Length];
        Console.WriteLine("Please fill the requested information.");
        for (int i = 0; i < user.Length; i++)
        {
            Console.Write("{0}: ", program[i]);
            user[i] = Console.ReadLine();
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The information you have filled out is as follows :");
        Console.WriteLine();
        for (int i = 0; i < user.Length; i++)
        {
            Console.WriteLine("{0}: {1}", program[i], user[i]);
        }

    }
}

