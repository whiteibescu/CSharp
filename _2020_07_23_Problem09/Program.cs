using System;

namespace _2020_07_23_Problem09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("정수를 입력해주세요 : ");
            string input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            for (int i = 0; i < num; ++i)
            {
                for (int j = 0; j <= i; ++j)
                {
                    if (j == i)
                    {
                        Console.Write("o");
                    }
                    else
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
