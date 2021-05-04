using System;

namespace HustarDay02
{
    class Cat
    {
        public Cat()
        {
            Console.WriteLine("public Cat() 생성자 호출");
        }
        private int m_iAge;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
        }
    }
}
