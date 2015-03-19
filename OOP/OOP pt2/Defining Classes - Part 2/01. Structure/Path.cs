using System.Collections.Generic;

namespace Structure
{
    public class Path
    {
        private List<Point3D> points;

        public List<Point3D> Points
        {
            get 
            {
                return this.points;
            }
            private set
            {
                this.points = value;
            }
        }
        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D currentPoint)
        {
            this.points.Add(currentPoint);
        }

        public void RemovePoint(Point3D pointToRemvoe)
        {
            this.points.Remove(pointToRemvoe);
        }

        
    }
}
