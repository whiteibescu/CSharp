using System;

namespace _2020_07_23Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 1;

            while (num != 0)
            {
                Console.WriteLine("정수를 입력해주세요 : ");
                Console.WriteLine("합산을 원하면 0을 입력해주세요. ");
                string Input = Console.ReadLine();
                num = Convert.ToInt32(Input);
                sum += num;
            }

            Console.WriteLine("입력된 정수들의 합 : {0}", sum);
        }
    }
}



