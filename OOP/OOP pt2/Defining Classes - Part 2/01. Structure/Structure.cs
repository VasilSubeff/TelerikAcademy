using System;

namespace Structure
{
    class StructureMain
    {
        static void Main()
        {
            Point3D onePoint = new Point3D(3, 4, 5);
            Console.WriteLine(onePoint.ToString());
            Point3D secondPoint = new Point3D(6, 7, 8);
            Console.WriteLine(Point3D.PointO.ToString());

            double distance = Distance.CalculateDistance(onePoint, secondPoint);
            Console.WriteLine(distance);

            Path seq = new Path();

            PathStorage.LoadPoints(seq);

            PathStorage.SavePoints(seq);
        
        }
    }
}
