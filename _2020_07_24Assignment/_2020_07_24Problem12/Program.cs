using System;

namespace _2020_07_24Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;

            Console.WriteLine("1부터 10까지 곱해서 결과를 출력합니다 : ");
            
            for (int i =2; i < 11; ++i )
            {
                sum *= i;
                Console.WriteLine("i : " + i + "sum : " + sum);
            }
        }
    }
}
