using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay03
{
    class Cat
    {
        public int m_iAge;
    }

    class SystemObject
    {
        static void main(string[] args)
        {            
            int i = 10;
            object oi = i;
            Console.WriteLine("{0}", i.ToString());
            Cat c1 = new Cat();
            object oc = c1;
            Console.WriteLine("{0}", c1.ToString());
        }
    }
}
