using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay03
{
    class SystemObject02
    {
        class Cat
        {
            public override bool Equals(object obj)
            {
                return base.Equals(obj);
            }
            public override string ToString()
            {
                return "m_Name :" + m_Name;
            }
            public string GetName()
            {
                return m_Name;
            }
            public void SetAge(string Name)
            {
                m_Name = Name;
            }
            private string m_Name;
        }

        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.SetAge("홍길동");
            Cat c2 = new Cat();
            c2.SetAge("홍길동");

            if (c1.Equals(c2))
            {
                Console.WriteLine("c1 == c2");
            }
            else
            {
                Console.WriteLine("c1 != c2");
            }
        }
    }
}
