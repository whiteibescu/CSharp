using System;

namespace _2020_07_23_Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("첫 번째 수: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("두 번째 수: ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("최소공배수: " + lcm(x, y)); //최소공배수를 구하고자 하는 두 수
        }

        public static int lcm(int x, int y)//least common multiple
        {
            if (x >= y)
                return x * y / gcd(x, y);
            else
                return x * y / gcd(y, x);
        }

        public static int gcd(int x, int y)//greatest common divisor
        {
            if (y == 0)
            return x;
            int r = x % y;
            x = y;
            y = r;
            return gcd(x, y);
        }
    }
}
