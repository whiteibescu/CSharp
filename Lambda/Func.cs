using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    class Func
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 123;
            Console.WriteLine("func1의 값 : {0}", func1());
            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine("func2의 값: {0}", func2(5));
        }

    }
}
