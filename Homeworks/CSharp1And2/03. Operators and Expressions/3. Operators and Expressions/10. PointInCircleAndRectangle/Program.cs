//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;

class PointInCirleAndRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter X for point");
        double pointX = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y for point");
        double pointY = double.Parse(Console.ReadLine());
        double centerX = 1.1D;
        double CenterY = 3;
        double radius = (centerX * centerX) + (CenterY * CenterY);
        double pointDistance = (pointX - centerX) * (pointX - centerX) + (pointY - CenterY) * (pointY - CenterY);
        if ((pointDistance <= radius) && (pointX >= -1 && pointX <= 5) && (pointY <= 1 && pointY >= -1))
        {
            Console.WriteLine("The point is in the cirlce and in the rectangle");
        }
        else
        {
            Console.WriteLine("The point is our of circle or our of rectangle ");
        }



    }
}

