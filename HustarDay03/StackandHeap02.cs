using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay03
{
    class StackandHeap02
    {
        class Cat
        {
            public string name;
        }
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Console.WriteLine("c1.name:{0},", c1.name);
            c1.name = "야옹이";
            Console.WriteLine("c1.name:{0},", c1.name);
        }
    }
}
