//The gravitational field of the Moon is approximately 17% of that on the Earth.
//Write a program that calculates the weight of a man on the moon by a given weight on the Earth.

using System;

class GravitaionOfTheMoon
{
    static void Main()
    {
        decimal earthGravity = 9.8M;
        decimal moonGravity = 0.17M;
        Console.Write("How much do you weight (kg) ? ");
        decimal weigth = decimal.Parse(Console.ReadLine());
        decimal force = weigth * earthGravity;
        Console.WriteLine("You will weight {0} kg on the moon !", force * moonGravity);
    }
}

