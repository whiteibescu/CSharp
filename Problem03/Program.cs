using System;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            
            int num;
            Console.WriteLine("홀수 구구단 출력은 1번 or 짝수 구구단 출력은 2번 ");
            string input = Console.ReadLine();
            num = Convert.ToInt32(input);
            for (i = 1; i < 10; ++i)
            { 
                if (num == 1)
                {
                    if (i%2 != 0)
                    {
                        continue;
                    }    
                }
                if (num == 2)
                {
                    if (i%3 != 0)
                    {
                        continue;
                    }
                }
                for (j = 1; j < 10; ++j)
                {
                    Console.WriteLine(i + " x " + j + " = " + i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
