using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay02
{
    class Cat
    {
        private Cat()
        {
            ++m_iStaticCount;
        }
        public void MyFunc() // public void MyFunc(Cat this)
        {
            Console.WriteLine("public void MyFunc()함수 호출");
        }
        public static Cat CreateObject()
        {
            if (m_iStaticCount < 5)
            {
                return new Cat();
            }
            return null; //주소 0번지를 넣는다
        }
        public void SetAge(int iAge)
        {
            m_iAge = iAge;
        }
        private int m_iAge;
        private static int m_iStaticCount;

        class CSharp
        {
            static void Main(string[] args)
            {
                Cat c = Cat.CreateObject();

            }
        }
    }
}

