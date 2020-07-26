using System;

namespace _2020_07_24Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 ~ 99 사이의 정수를 입력하시오 >> ");
            int num = Convert.ToInt32(Console.ReadLine());
            int tenth = num / 10;
            int one = num % 10;

            if (tenth == 3 || tenth == 6 || tenth == 9)
            {
                if (one == 3 || one == 6 || one == 9)
                    Console.WriteLine("박수짝짝");
                else
                    Console.WriteLine("박수짝");
            }
            else
            {
                if (one == 3 || one == 6 || one == 9)
                    Console.WriteLine("박수짝");
            }
        }
    }
}
