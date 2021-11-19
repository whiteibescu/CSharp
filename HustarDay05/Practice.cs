using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay05
{
    class Cat
    {
        public int m_iAge;
    }

    class Solution
    {
        int noStatic = 0;
        static int yesStatic = 0;

        public static void yes()
        {
            int noStatic = 0;
            yesStatic = 0;
        }

        public void no()
        {
            noStatic = 1;
            yesStatic = 1;
        }
    }


    class ChangeByValueorReference
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.m_iAge = 10;
        }
    }
}
