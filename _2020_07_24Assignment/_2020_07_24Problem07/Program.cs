using System;

namespace _2020_07_24Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("x좌표를 입력하세요 >> ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("y좌표를 입력하세요 >> ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x >= 50 && x <= 100 && y >= 50 && y <= 100)
            {
                Console.WriteLine("겹침");
            }
            else
            {
                Console.WriteLine("안겹침");
            }
        }
    }
}
