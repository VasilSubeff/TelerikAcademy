//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class RectangleSandP
{
    static void Main()
    {
        Console.Write("Enter a width: ");
        decimal width = decimal.Parse(Console.ReadLine());
        Console.Write("Enter a height: ");
        decimal height = decimal.Parse(Console.ReadLine());
        Console.WriteLine("The perimeter of the rectangle is {0} !", (2 * width) + (2*height));
        Console.WriteLine("The area of the rectangle is {0} !", width * height);
    }
}
