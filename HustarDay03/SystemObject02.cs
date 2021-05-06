using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuStarDay03
{
    class Cat
    {
        public override bool Equals(object obj)
        //     public override bool Equals(Cat this,object obj)
        //     Cat this = c1, object obj = c2
        {
            Cat rhs = (Cat)obj;
            return this.m_Name == rhs.m_Name;
            bool Imsi = true;
        }
        public override string ToString()
        {
            return "m_Name :" + m_Name;
        }
        public string GetName()
        {
            return m_Name;
        }
        public void SetName(string Name)
        //       Cat this = c2,string Name = "홍길동"
        {
            this.m_Name = Name;
        }
        private string m_Name;
    }
    class SystemObject02
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Cat c2 = new Cat();

            c1.SetName("홍길동");
            //          SetName(c1,"홍길동");
            c2.SetName("홍길동");
            //          SetName(c2,"홍길동");

            if (c1.Equals(c2))
            //              Imsi
            //             Equals(c1,c2)
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