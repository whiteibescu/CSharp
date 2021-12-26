using System;

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
}