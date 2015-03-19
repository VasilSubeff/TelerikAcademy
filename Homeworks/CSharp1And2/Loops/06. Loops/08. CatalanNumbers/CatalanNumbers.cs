using System;

class CatalanNumbers
{
    static double Factorial(double n)
    {
        double nFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        return nFactorial;
    }
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Invalid input! N = 0 or N > 0");
            }
        }
        while (n < 0);
        double catalanNumbers = 0;
        catalanNumbers = Factorial(2 * n) / Factorial(1 + n) * Factorial(n);
        Console.WriteLine("Cn = {0}", catalanNumbers);
    }
}

