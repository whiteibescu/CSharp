using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay02
{
    class Important
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Console.WriteLine("x:{0},y:{1}", x, y);
            MySwap(x, y);
            Console.WriteLine("x:{0},y:{1}", x, y);
        }

        static void MySwap(int px, int py)
        {
            int temp = px;
            px = py;
            py = temp;
        }
    }
}
