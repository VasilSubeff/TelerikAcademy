using System;
using System.IO;

namespace Structure
{
    public class PathStorage
    {
        public static void LoadPoints(Path newPath)
        {
            StreamReader reader = new StreamReader(@"..\..\PointsToAdd.txt");
            using (reader)
            {
                string line = reader.ReadLine();
                
                while (line != null)
                {
                    newPath.AddPoint(Point3D.Parse(line));
                    line = reader.ReadLine();
                }
            }

            Console.WriteLine("Points loaded to PointsToAdd.txt");
        }

        public static void SavePoints(Path pointsToSave)
        {
            StreamWriter writer = new StreamWriter(@"..\..\FileToSavePoints.txt");
            
            using (writer)
            {
                for (int i = 0; i < pointsToSave.Points.Count; i++)
                {
                    writer.WriteLine(pointsToSave.Points[i].ToString());
                }
            }

            Console.WriteLine("Points saved to FileToSavePoints.txt");
        }
    }
}
