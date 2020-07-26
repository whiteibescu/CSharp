using System;

namespace _2020_07_24Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int num = 0;
            Console.WriteLine("정수 10개를 입력하세요: ");

            for (int i = 0; i < 10; ++i)
            {
                string v = Console.ReadLine();
                num = Convert.ToInt32(v);
                arr[i] = num;
            }
            
            for (int i = 0; i < 10; ++i)
            {
                if (arr[i] % 3 == 0)
                {
                    Console.WriteLine("3의 배수 " + arr[i]);
                }
                else if (arr[i] % 2 == 0)
                {
                    Console.WriteLine("2의 배수 " +arr[i]);
                }
            }
        }
    }
}