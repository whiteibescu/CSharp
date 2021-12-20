using System;

namespace Night
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return String.Format($"{x}, {y}, {z}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Point3D a;
            a.x = 10;
            a.y = 20;
            a.z = 30;

            Point3D b = new Point3D(10, 20, 30);
            Point3D c = b;
            c.z = 40;

            Console.WriteLine($"{a.ToString()}");
            Console.WriteLine($"{b.ToString()}");
            Console.WriteLine($"{c.ToString()}");
        }
    }
}