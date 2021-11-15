using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Wing
    {
        public void Fly()
        {
            Console.WriteLine("날기...");
        }
    }
    class Bird
    {
        Wing w = new Wing();
        public void Fly()
        {
            w.Fly();
        }

        public virtual void Speak()
        {
            Console.WriteLine("짹짹...");
        }
        public virtual void Alggagi()
        {
            Console.WriteLine("알까기...");
        }
        private int[] m_iArray = new int[1000];
    }
    class Pegasus
    {
        public void Gallop()
        {
            Console.WriteLine("달리기...");
        }
        public void Speak()
        {
            Console.WriteLine("히잉~~~");
        }
        public void Fly()
        {
            m_Wing.Fly();
        }
        Wing m_Wing = new Wing();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pegasus p = new Pegasus();
            p.Gallop();
            p.Fly();
            p.Speak();
        }
    }
}