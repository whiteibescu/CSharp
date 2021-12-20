using System;
using System.Collections;

namespace Practice
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("생성자 호출");
        }

        public virtual void Speak()
        {
            Console.WriteLine("default");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("강아지 생성자 호출");
        }

        public override void Speak()
        {
            Console.WriteLine("멍멍");
        }
    }

    class Cat : Animal
    {
        public Cat()
        {
            Console.WriteLine("고양이 생성자 호출");
        }

        public override void Speak()
        {
            Console.WriteLine("냥냥");
        }
    }

    class Horse : Animal
    {
        public Horse()
        {
            Console.WriteLine("말 생성자 호출");
        }

        public override void Speak()
        {
            Console.WriteLine("이히힝");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList animalList = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Press 1 for Cat");
                Console.WriteLine("Press 2 for Dog");
                Console.WriteLine("Press 3 for Horse");




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