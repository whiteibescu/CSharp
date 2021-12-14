using System;

namespace PartialClass
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
            Console.WriteLine($"{this.Name}.Base");

        public void Method2()
        ~Base()
            Console.WriteLine("Method2");
            Console.WriteLine($"{this.Name}.~Base");
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived");
        }
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}