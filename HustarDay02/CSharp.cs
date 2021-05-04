using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay02
{
    class Cat
    {
        public Cat()
        {
            int cnt = 0;
            cnt = ++m_iStaticCount;
            Console.WriteLine("객체 갯수: ", cnt);
        }
        public void MyFunc() // public void MyFunc(Cat this)
        {
            Console.WriteLine("public void MyFunc()함수 호출");
            MyFunc2();
            //this.MyFunc2(); MyFunc2 함수와 같은 의미이다
        } 

        public void MyFunc2()
        {
            Console.WriteLine("public void MyFunc2()함수 호출");
        }
        public static void MyStaticFunc() //public static void MyStaticVoid()
            //static 멤버 함수는 없어
        {
            Console.WriteLine("public static void MyStaticFunc()함수호출");
            MyStaticFunc2();
        }

        public static void MyStaticFunc2() //public static void MyStaticVoid()
                                          //static 멤버 함수는 없어
        {
            Console.WriteLine("public static void MyStaticFunc()함수호출");

        }
        private int m_iAge;
        private static int m_iStaticCount;
    }

    class CSharp
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            Cat c2 = new Cat();
        }
    }
}
