using System;

namespace _2020_07_23_Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; ++i)
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
