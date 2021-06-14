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
            Console.WriteLine("나이 : {0}", m_iAge);
        }
        public void InputData()
        {
            Console.Write("이름 : ");
            m_Name = Console.ReadLine();
            Console.Write("나이 : ");
            m_iAge = int.Parse(Console.ReadLine());
        }
        private string m_Name;
        private int m_iAge;
    }
    class Cat : Animal
    {
        public override Animal Clone()
        {
            return new Cat();
        }
        public override string GetAnimalType()
        {
            return "고양이";
        }
        public override void Speak()
        {
            Console.WriteLine("야옹"); ;
        }
    }

}