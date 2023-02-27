using System;

namespace FuncTest
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Func<int> func = () => 10;
            Console.WriteLine(func());

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine(func2(4));

            Func<double, double, double> func3 = (x, y) => x / y;
            Console.WriteLine(func3(22, 7));
        }
    }

}