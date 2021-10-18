using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManager
{ 
    abstract class Animal
    {
        public abstract Animal Clone();
        public abstract void Speak();
        public abstract string GetAnimalType();
        public string GetName()
        {
            return m_Name;
        }

        public void PrintData()
        {
            Console.WriteLine("이름 : {0}", m_Name);
        }

        private string m_Name;
        private int m_iAge;
    }
}