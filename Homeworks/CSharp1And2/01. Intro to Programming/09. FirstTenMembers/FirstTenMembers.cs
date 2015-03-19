using System;

class FirstTenMembers
{
    static void Main()
    {
        int number = 2;
        for (int i = 2; i < 12; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine(i*-1);
            }
        }
    }
}

