using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    delegate int dele(int a);

    class Program
    {
        static void Main(string[] args)
        {
            dele d = delegate (int a) { return a + 1; };
            int k = d(3);
            Console.WriteLine("k = " + k);
        }
    }
}