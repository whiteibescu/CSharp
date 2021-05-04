    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace HustarDay02
    {
        class Cat
        {
            public int m_iAge;
        }
        class DrawThis
        {
            static void Main(string[] args)
            {
                Cat c1 = new Cat();
                c1.m_iAge = 10;
                Cat c2 = new Cat();
                c2.m_iAge = 20;
                Console.WriteLine("c1.m_iAge : {0},c2.m_iAge : {1}", c1.m_iAge, c2.m_iAge);
                MySwap(c1, c2);
                Console.WriteLine("c1.m_iAge : {0},c2.m_iAge : {1}", c1.m_iAge, c2.m_iAge);
            }

            static void MySwap(Cat pc1, Cat pc2)
            {
                Cat temp = pc1;
                pc1 = pc2;
                pc2 = temp;
            }
        }
    }
