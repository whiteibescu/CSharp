using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay02
{
    class CallByReference
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("x:{0},y:{1}", x, y);
            MySwap(ref x, ref y);
            Console.WriteLine("x:{0},y:{1}", x, y);
        }

        static void MySwap(ref int px, ref int py)
        {
            int temp = px;
            px = py;
            py = temp;
        }
    }
}
