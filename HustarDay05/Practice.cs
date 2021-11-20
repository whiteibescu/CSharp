using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("public Animal()생성자 호출");
        }
        public virtual void Speak()
        {
            Console.WriteLine("Animal Speak!!!");
        }
        public virtual void Speak2()
        {
            Console.WriteLine("Animal2 Speak!!!");
        }
        private int m_iAge;
    }
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("public Cat()생성자 호출");
        }
        public override void Speak2()
        {
            Console.WriteLine("야옹2!!!");
        }
        public override void Speak()
        {
            Console.WriteLine("야옹!!!");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("public Dog()생성자 호출");
        }
        public override void Speak()
        {
            Console.WriteLine("멍멍!!!");
        }
    }
    class Horse : Animal
    {
        public Horse()
        {
            Console.WriteLine("public Horse()생성자 호출");
        }
        public override void Speak()
        {
            Console.WriteLine("히잉!!!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Animal();
            a.Speak();
            Animal a1 = new Cat();
            a1.Speak2();
        }
    }
}