using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override
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
    }
    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("public Cat()생성자 호출");
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
            ArrayList animalList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("1.Cat");
                Console.WriteLine("2.Dog");
                Console.WriteLine("3.Horse");
                int iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        animalList.Add(new Cat());
                        break;
                    case 2:
                        animalList.Add(new Dog());
                        break;
                    case 3:
                        animalList.Add(new Horse());
                        break;
                }
            }
            for (int i = 0; i < animalList.Count; i++)
            {
                Animal a = (Animal)animalList[i];
                a.Speak();
            }
        }
    }
}