using System.Linq;

namespace Structure
{
    public struct Point3D
    {
        private static readonly Point3D O;

        public int X { get; private set; }
        public int Y { get; private set; }
        public int Z { get; private set; }

        static Point3D() //task 2
        {
            O = new Point3D(0, 0, 0);
        }

        public Point3D(int currentX, int currentY, int currentZ) //task 1
            : this()
        {
            this.X = currentX;
            this.Y = currentY;
            this.Z = currentZ;
        }

        public override string ToString() // task 1
        {

            return string.Format("X = {0}; Y = {1}; Z = {2}", this.X, this.Y, this.Z);
        }

        public static Point3D PointO // task 2
        {
            get
            {
                return O;
            }
        }

        public static Point3D Parse(string pointCordinates)
        {
            int[] cordinates = pointCordinates.Split(' ').Select(int.Parse).ToArray();
            Point3D currentPoint = new Point3D(cordinates[0], cordinates[1], cordinates[2]);
            return currentPoint;
        }
    }
}
