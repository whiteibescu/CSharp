using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Cat
    {
        public int m_iAge;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            Console.WriteLine(c1.ToString());
            Console.WriteLine("c1.m_iAge : {0}", c1.m_iAge);
            Object o1 = c1;
            Console.WriteLine("o1.m_iAge : {0}", o1.m_iAge);
        }
    }
}