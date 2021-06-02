using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay07
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
            Console.WriteLine("나이 : {0}", m_iAge);
        }

        public void InputData()
        {
            Console.WR
        }


        private string m_Name;
        private int m_iAge;
    }
    class Practice
    {
    }
}
