using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicClass
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class MainApp
    {
        static void Main()
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassB();
            new ClassB();
            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}