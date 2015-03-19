using System;

class Breakpoint
{
    static void Main()
    {
        for (int i = 0; i < 1000; i++)
        {
            Console.WriteLine(i + 1);
            //Press F10 then execute every iteration with F5.
        }
    }
}

