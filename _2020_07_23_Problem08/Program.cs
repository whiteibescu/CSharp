using System;

namespace _2020_07_23_Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;            
            int sum = 0;

            Console.WriteLine("정수 두개를 입력 해주세요 : ");
            string input = Console.ReadLine();
            string input2 = Console.ReadLine();

            x = Convert.ToInt32(input);
            y = Convert.ToInt32(input2);

            for (int i = x; i <= y; ++i)
            {
                sum += i;
            }
            Console.WriteLine(sum);

        }
    }
}
