using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Test9
{
    delegate void DispChar(int i);
    class Program
    {
        static void DispStar(int i)
        {
            Console.Write("*");
        }
        static void DispArrow(int i)
        {
            Console.Write("->");
        }
        static void DispPercent(int i)
        {
            Console.WriteLine("{0}%작업완료", i * 10);
        }
        static void MyFunc(DispChar dispChar)
        {
            for (int i = 1; i <= 10; i++)
            {
                dispChar(i);
                Thread.Sleep(100);
            }
        }
        static void Main(string[] args)
        {
            MyFunc(DispPercent);
        }
    }
}