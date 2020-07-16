using System;

namespace A
{
    class MyClass { int i; }
}

namespace B
{
    class MyClass { double d; }
}

namespace _3_Namespace
{
    class Program
    {
        static void Main(string[] args)
        {
            A.MyClass objA = new A.MyClass();
            B.MyClass objB = new B.MyClass();
            Console.WriteLine(objA.ToString());
            Console.WriteLine(objB.ToString());
        }
    }
}