using System;

namespace _2020_07_24Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = 0;
            Console.WriteLine("연도를 입력하세요 : ");
            year = Convert.ToInt32(Console.ReadLine());

            if(year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("윤년입니다", year);
            }
            else
            {
                Console.WriteLine("평년입니다", year);
            }
        } 
    }
}
/*
6. 연도를 입력받으세요
   윤년인지 아닌지를 판별하세요
   4로 나누어 떨어지는 해는 일단 윤년에 포함시킵니다
   하지만 윤년중에 100으로 나누어떨어지는 해는 평년으로 하되
   평년중에 400으로 나누어 떨어지는 해는 윤년에 해당합니다*/