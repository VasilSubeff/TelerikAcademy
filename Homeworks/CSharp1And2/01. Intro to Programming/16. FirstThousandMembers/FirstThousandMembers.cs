using System;
class FirstThousandMembers
{
    static void Main()
    {
        int number = 2;
        for (int i = 0; i < 1000; i++)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine(number * -1);
            }
            number++;
        }
    }
}

