using System;

namespace _2020_07_23_Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;

            for ( i= 1; ; ++i)
            {
                sum += i;
                if (sum > 1000)
                    break;
            }
            Console.WriteLine("합은" + sum + "이고 마지막으로 더해진 수는 " + i + "이다.");
        }
    }
}
