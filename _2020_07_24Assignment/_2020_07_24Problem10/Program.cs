using System;

namespace _2020_07_24Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; ++i)
            {
                arr[i] = random.Next(10);

                Console.WriteLine("10개의 난수생성: " + arr[i]);
                
                if (arr[i] % 2 != 0 || arr[i] == 1)
                {
                    Console.WriteLine("홀수 :" + arr[i]);
                }
            }
        }
    }
}
