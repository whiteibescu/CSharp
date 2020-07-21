using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace _39_Random
{
    struct Point
    {
        private int left;
        private int top;

        public int Left { get => left; set => left = value; }
        public int Top { get => top; set => top = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point[] points = new Point[100];
            Random R = new Random();
            for (int i = 0; i < 100; i++)
            {
                Console.CursorLeft = R.Next(80);//0 ~ 79
                Console.CursorTop = R.Next(24);// 0 ~ 23
                Console.Write('*');
                Thread.Sleep(10);

                points[i].Left = Console.CursorLeft;
                points[i].Top = Console.CursorTop;
            }
            for(int i = points.Length - 1; i >= 0; i--)
            {
                Console.CursorLeft = points[i].Left;
                Console.CursorTop = points[i].Top;
                Console.Write("  ");
                Thread.Sleep(10);
            }
        }
    }
}
