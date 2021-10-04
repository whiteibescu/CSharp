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
            dele d = a => a + 1;
            int k = d(3);
            Console.WriteLine("k = " + k);
        }
    }
}