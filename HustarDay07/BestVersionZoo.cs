﻿using System;
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
            Console.WriteLine("이름 : {0}",m_Name);
            Console.WriteLine("나이 : {0}",m_iAge);
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
    class Dog : Animal
    {
        public override Animal Clone()
        {
            return new Dog();
        }
        public override string GetAnimalType()
        {
            return "개";
        }
        public override void Speak()
        {
            Console.WriteLine("멍멍"); ;
        }
    }
    class Pig : Animal
    {
        public override Animal Clone()
        {
            return new Pig();
        }
        public override string GetAnimalType()
        {
            return "돼지";
        }
        public override void Speak()
        {
            Console.WriteLine("꿀꿀"); ;
        }
    }
    class Horse : Animal
    {
        public override Animal Clone()
        {
            return new Horse();
        }
        public override string GetAnimalType()
        {
            return "말";
        }
        public override void Speak()
        {
            Console.WriteLine("히이"); ;
        }
    }
    class Tiger : Animal
    {
        public override Animal Clone()
        {
            return new Tiger();
        }
        public override string GetAnimalType()
        {
            return "호랑이";
        }
        public override void Speak()
        {
            Console.WriteLine("어흥"); ;
        }
    }
    class AnimalMenu
    {
        public Animal Menu()
        {
            for (int i = 0; i < AnimalMenuList.Count; i++)
            {
                Console.WriteLine("{0}.{1}",i+1,AnimalMenuList[i].GetAnimalType());
            }
            int iChoice = int.Parse(Console.ReadLine());
            if (iChoice > 0 && iChoice <= AnimalMenuList.Count)
            {
                return AnimalMenuList[iChoice - 1].Clone();
            }
            return null;
        }
        private List<Animal> AnimalMenuList = new List<Animal>()
        {
            new Cat(),new Dog(),new Pig(),new Horse(),new Tiger(),
        };
    }
    class AnimalCountNode
    {
        public AnimalCountNode(string AnimalType)
        {
            m_AnimalType = AnimalType;
        }
        public void PrintAnimalCount()
        {
            Console.WriteLine("{0} : {1}마리", m_AnimalType, m_iAnimalCount);
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
                AnimalCountNode animalCountNode = SearchAnimalCountNode(AnimalList[i].GetAnimalType());
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
        public void PrintAnimalCount()
        {
            for (int i = 0; i < m_AnimalCountList.Count; i++)
            {
                m_AnimalCountList[i].PrintAnimalCount();
            }
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
                Console.WriteLine("1. 동물등록");
                Console.WriteLine("2. 동물출력");
                Console.WriteLine("3. Speak");
                Console.WriteLine("4. 동물이송");
                Console.WriteLine("5. 동물Count");
                Console.WriteLine("0. 종료");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        RegistAnimal();
                        break;
                    case 2:
                        PrintAllAnimals();
                        break;
                    case 3:
                        SpeakAllAnimals();
                        break;
                    case 4:
                        MoveAnimal(zooTarget);
                        break;
                    case 5:
                        AnimalCount();
                        break;
                    default:
                        break;
                }
            }
        }
        public void AnimalCount()
        {
            AnimalCountMgr CountMgr = new AnimalCountMgr();
            CountMgr.CountAnimal(m_AnimalList);
        }
        public int AnimalMoveMenu()
        {
            for (int i = 0; i < m_AnimalList.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, m_AnimalList[i].GetName());
            }
            int iChoice = int.Parse(Console.ReadLine());
            if (iChoice > 0 && iChoice <= m_AnimalList.Count)
            {
                return iChoice - 1;
            }
            return -1;
        }
        private void MoveAnimal(Animal MoveAnimal)
        {
            m_AnimalList.Add(MoveAnimal);
        }
        private void MoveAnimal(Zoo zooTarget)
        {
            int iChoice = AnimalMoveMenu();
            if (iChoice != -1)
            {
                zooTarget.MoveAnimal(m_AnimalList[iChoice]);
                m_AnimalList.RemoveAt(iChoice);
            }
        }
        private void RegistAnimal()
        {
            Animal NewAnimal = m_AnimalMenu.Menu();
            if (NewAnimal != null)
            {
                NewAnimal.InputData();
                m_AnimalList.Add(NewAnimal);
            }
        }
        private void PrintAllAnimals()
        {
            for (int i = 0; i < m_AnimalList.Count; i++)
            {
                m_AnimalList[i].PrintData();
            }
        }
        private void SpeakAllAnimals()
        {
            for (int i = 0; i < m_AnimalList.Count; i++)
            {
                m_AnimalList[i].Speak();
            }
        }
        private AnimalMenu m_AnimalMenu = new AnimalMenu();
        private List<Animal> m_AnimalList = new List<Animal>();
    }
    class ZooManager
    {
        public void Menu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. A동물원");
                Console.WriteLine("2. B동물원");
                Console.WriteLine("0. 종료");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        m_ZooA.Menu(m_ZooB);
                        break;
                    case 2:
                        m_ZooB.Menu(m_ZooA);
                        break;
                    default:
                        break;
                }
            }
        }
        private Zoo m_ZooA = new Zoo();
        private Zoo m_ZooB = new Zoo();
    }
    class Program
    {
        static void Main(string[] args)
        {
            ZooManager z = new ZooManager();
            z.Menu();
        }
    }
}