using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Cat
    {
        static Cat()
        {
            Console.WriteLine("static Cat() 생성자 호출");
            m_iCount = 0;
        }
        public Cat(float pi = 3.14f)
        {
            Console.WriteLine("public Cat(float pi) 생성자 호출");
            m_pi = pi;
        }
        public void MyFunc()
        {
            AGE = 10;
        }
        public int AGE
        {
            get { return m_iAge; }
            private set
            {
                if(value < 0)
                {
                    Console.WriteLine("나이는 0보다 작을 수 없습니다.");
                    return;
                }
                m_iAge = value;
            }
        }
        public static int COUNT
        {
            get { return m_iCount; }
        }

        private int m_iAge;
        private static int m_iCount;
        public readonly float m_pi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("{0}", Cat.COUNT);
            Console.WriteLine("------------------------------");
            Cat c1 = new Cat(3.141592f);
            Console.WriteLine("{0}", c1.m_pi);
        }
    }
}