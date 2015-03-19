//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;

class NFonKF
{
    static void Main()
    {
        Console.WriteLine("Enter N and K in 1 < k < n < 100 !");
        int k, n = 0;
        do
        {
            Console.Write("Enter N: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Enter K: ");
            k = int.Parse(Console.ReadLine());
        } while ((n < 1 || n > 100) || ( k < 1 || k >100) || k >= n);

        int result = 1;
        for (int i = 0; i < (n - k); i++)
        {
            result = result * (n - i);
        }
        Console.WriteLine("N!/K! = {0}", result);
        
    }
}
