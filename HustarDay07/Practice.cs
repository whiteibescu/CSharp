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
            Console.Write("이름 : ");
            m_Name = Console.ReadLine();
            Console.Write("나이 : ");
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
            Console.WriteLine("야옹");
        }
    }

    class AnimalMenu
    {
        public Animal Menu()
        {
            for (int i = 0; i < AnimalMenuList.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, AnimalMenuList[i].GetAnimalType());
            }
            int iChoice = int.Parse(Console.ReadLine());
            if (iChoice > 0 && iChoice <= AnimalMenuList.Count)
            {
                return Anim
                    alMenuList[iChoice - 1].Clone();
            }
            return null;
        }

        private List<Animal> AnimalMenuList = new List<Animal>()
        {
            new Cat(), new Dog(), new Pig(), new Horse(), new Tiger().
        };
    }

    class AnimalCountNode
    {
        public AnimalCountNode(string AnimalType)
        {
            m_AnimalType = AnimalType;
        }
        public void Increment()
        {
            ++m_iAnimalCount;
        }
        public bool CompareAnimalType(string animalType)
        {
            return animalType == m_AnimalType;
        }
        private string m_AnimalType;
        private int m_iAnimalCount = 1;
    }

    class AnimalCountMgr
    {
        public void CountAnimal(List<Animal> AnimalList)
        {
            for (int i = 0; i < AnimalList.Count; i++)
            {
                AnimalCountNode animalCountNode = SearchANimalCountNode(AnimalList[i].GetAnimalType());
                if (animalCountNode == null)
                {
                    m_AnimalCountList.Add(new AnimalCountNode(AnimalList[i].GetAnimalType()));
                }
                else
                {
                    animalCountNode.Increment();
                }

            }
            PrintAnimalCount();
        }
        public void PrintAnimalCount()
        {
            for (int i = 0; i < m_AnimalCountList.Count; i++)
            {
                m_AnimalCountList[i].PrintAnimalCount();
            }
        }
        public AnimalCountNode SearchAnimalCountNode(string animalType)
        {
            for (int i = 0; i < m_AnimalCountList.Count; i++)
            {
                if (m_AnimalCountList[i].CompareAnimalType(animalType))
                {
                    return m_AnimalCountList[i];
                }
            }
            return null;
        }
        private List<AnimalCountNode> m_AnimalCountList = new List<AnimalCountNode>();
    }

    class Zoo
    {
        public void Menu(Zoo zooTarget)
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine()
            }
        }
    }
}
