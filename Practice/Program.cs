using System;
using System.Collections;

namespace naming
{
    class Animal
    {
        public Animal()
        {
            Console.WriteLine("생성자 호출한다");
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
            ArrayList AnimalList = new ArrayList();
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Press 1 for dog");
                Console.WriteLine("Press 2 for cat");
                Console.WriteLine("Press 3 for horse");
                int select = int.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        AnimalList.Add(new Dog());
                        break;
                    case 2:
                        AnimalList.Add(new Cat());
                        break;
                    case 3:
                        AnimalList.Add(new Horse());
                        break;
                }
            }

            foreach(Animal animals in AnimalList)
            {
                animals.Speak();
            }

        }
    }
}