using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static int Add(int a)
        {
            return a + 1;
        }

        static void Main(string[] args)
        {
            int k = Add(3);
            Console.WriteLine("k = " + k);
        }
    }
}