using System;

namespace Lambda
{
    class Program
    {
        delegate void Calculate(int a, int b);
        static void Main()
        {
            Calculate cal = (int a, int b) =>
            {
                int sum = a + b;
                Console.WriteLine(sum);
            };

            cal(10, 20);
        }
    }
}
