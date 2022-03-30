using System;

namespace Facade_Pattern
{
    public class MainApp
    {
        public static void Main(string[] args)
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            Console.ReadKey();
        }
    }

    public class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemOne Method");
        }
    }
    public class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemTwo Method");
        }
    }

    public class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemThree Method");
        }
    }

    public class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubsystemFour Method");
        }
    }

    public class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\nMethodA() ----");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\nMethodA() ----");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}