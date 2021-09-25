using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] iArray = { 1, 2, 3, 4, 5 };
            Console.WriteLine(iArray);
            for (int i = 0; i < iArray.Length; i++)
            {
                Console.WriteLine("iArray[{0}] = {1}", i, iArray[i]);
            }
        }
    }
}