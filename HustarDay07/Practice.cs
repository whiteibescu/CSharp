using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace HustarDay07
{
    interface Animal
    {
        void Speak();
    }

    class Dog : Animal
    {
        public void Speak()
        {
            Console.WriteLine("멍멍!");
        }

        public int GetDogCnt()
        {
            return dogCnt;
        }

        public void SetDogCnt()
        {
            dogCnt += 1;
            Console.WriteLine("강아지 한마리가 추가되었습니다! 지금 현재 총 {0} 마리 입니다! ", dogCnt);
        }

        public void SubtractDogCnt(int iChoice)
        {
            if (dogCnt != 0)
            {
                dogCnt -= 1;
                Console.WriteLine("강아지 몇마뤼? {0} ", dogCnt);
            }
            else
            {
                Console.WriteLine("삭제할 동물이 없습니다!");
            }
        }

        private int dogCnt;
    }

    class Cat : Animal
    {
        public void Speak()
        {
            Console.WriteLine("냐옹!");
        }
        public int GetCatCnt()
        {
            return catCnt;
        }

        public void SetCatCnt()
        {
            catCnt += 1;
            Console.WriteLine("고양이 한마리가 추가되었습니다! 지금 현재 총 {0} 마리 입니다! ", catCnt);
        }

        public void SubtractCatCnt(int iChoice)
        {
            if (catCnt != 0)
            {
                catCnt -= 1;
                Console.WriteLine("고양이 한마리가 삭제되었습니다! 지금 현재 총 {0} 마리 입니다! ", catCnt);
            }
            else
            {
                Console.WriteLine("삭제할 동물이 없습니다!");
            }
        }

        private int catCnt;
    }

    class Lion : Animal
    {
        public void Speak()
        {
            Console.WriteLine("사자!!");
        }

        public int GetLionCnt()
        {
            return lionCnt;
        }

        public void SetLionCnt()
        {
            lionCnt += 1;
            Console.WriteLine("사자 한마리가 추가되었습니다! 지금 현재 총 {0} 마리 입니다! ", lionCnt);
        }

        public void SubtractLionCnt(int iChoice)
        {
            if (lionCnt != 0)
            {
                lionCnt -= 1;
                Console.WriteLine("사자 한마리가 삭제되었습니다! 지금 현재 총 {0} 마리 입니다! ", lionCnt);
            }
            else
            {
                Console.WriteLine("삭제할 동물이 없습니다!");
            }
        }

        private int lionCnt;
    }

    class Tiger : Animal
    {
        public void Speak()
        {
            Console.WriteLine("어흥!");
        }

        public int GetTigerCnt()
        {
            return tigerCnt;
        }

        public void SetTigerCnt()
        {
            tigerCnt += 1;
            Console.WriteLine("호랑이 한마리가 추가되었습니다! 지금 현재 총 {0} 마리 입니다! ", tigerCnt);
        }

        public void SubtractTigerCnt(int iChoice)
        {
            if (tigerCnt != 0)
            {
                tigerCnt -= 1;
                Console.WriteLine("호랑이 한마리가 삭제되었습니다! 지금 현재 총 {0} 마리 입니다! ", tigerCnt);
            }
            else
            {
                Console.WriteLine("삭제할 동물이 없습니다!");
            }
        }

        private int tigerCnt;
    }

    class Horse : Animal
    {
        public void Speak()
        {
            Console.WriteLine("이히히히힝");
        }

        public int GetHorseCnt()
        {
            return horseCnt;
        }

        public void SetHorseCnt()
        {
            horseCnt += 1;
            Console.WriteLine("말 한마리가 추가되었습니다! 지금 현재 총 {0} 마리 입니다! ", horseCnt);
        }

        public void SubtractHorseCnt(int iChoice)
        {
            if (horseCnt != 0)
            {
                horseCnt -= 1;
                Console.WriteLine("말 한마리가 삭제되었습니다! 지금 현재 총 {0} 마리 입니다! ", horseCnt);
            }
            else
            {
                Console.WriteLine("삭제할 동물이 없습니다!");
            }
        }

        private int horseCnt;
    }

    class ZooMgr
    {
        public void AddAnimalMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("Type Number of the animal you wish to Add!");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine("3. Lion");
                Console.WriteLine("4. Tiger");
                Console.WriteLine("5. Horse");
                Console.WriteLine("0. Menu");
                Console.WriteLine("==========================================");
                iChoice = int.Parse(Console.ReadLine());
                AddAnimalFunc(iChoice);

            }
        }

        public void DeleteAnimalMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("Type Number of the animal you wish to Delete!");
                Console.WriteLine("==========================================");
                Console.WriteLine("1. Dog");
                Console.WriteLine("2. Cat");
                Console.WriteLine("3. Lion");
                Console.WriteLine("4. Tiger");
                Console.WriteLine("5. Horse");
                Console.WriteLine("0. Menu");
                Console.WriteLine("==========================================");
                iChoice = int.Parse(Console.ReadLine());
                DeleteAnimalFunc(iChoice);
            }
        }

        public void AddAnimalFunc(int iChoice)
        {
            switch (iChoice)
            {
                case 1:
                    a.SetDogCnt();
                    break;
                case 2:
                    c.SetCatCnt();
                    break;
                case 3:
                    l.SetLionCnt();
                    break;
                case 4:
                    t.SetTigerCnt();
                    break;
                case 5:
                    h.SetHorseCnt();
                    break;
            }
        }

        public void DeleteAnimalFunc(int iChoice)
        {
            switch (iChoice)
            {
                case 1:
                    a.SubtractDogCnt(iChoice);
                    break;
                case 2:
                    c.SubtractCatCnt(iChoice);
                    break;
                case 3:
                    l.SubtractLionCnt(iChoice);
                    break;
                case 4:
                    t.SubtractTigerCnt(iChoice);
                    break;
                case 5:
                    h.SubtractHorseCnt(iChoice);
                    break;
            }

        }

        public void AnimalSpeak()
        {
            for (int i = 0; i < a.GetDogCnt(); i++)
            {
                a.Speak();
            }
            for (int i = 0; i < a.GetDogCnt(); i++)
            {
                c.Speak();
            }
            for (int i = 0; i < a.GetDogCnt(); i++)
            {
                l.Speak();
            }
            for (int i = 0; i < a.GetDogCnt(); i++)
            {
                t.Speak();
            }
            for (int i = 0; i < a.GetDogCnt(); i++)
            {
                h.Speak();
            }
        }

        public void AnimalList()
        {
            Console.WriteLine("강아지 {0} 마리", a.GetDogCnt());
            Console.WriteLine("고양이 {0} 마리", c.GetCatCnt());
            Console.WriteLine("사자 {0} 마리", l.GetLionCnt());
            Console.WriteLine("호랑이 {0} 마리", t.GetTigerCnt());
            Console.WriteLine("말 {0} 마리", h.GetHorseCnt());
        }

        public void AnimalTransfer()
        {

        }
        public void Menu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("Welcome to the Mysterious Zoo!~");
                Console.WriteLine("===============================");
                Console.WriteLine("");
                Console.WriteLine("Menu!");
                Console.WriteLine("1. Add Animal");
                Console.WriteLine("2. Delete Animal");
                Console.WriteLine("3. Speak");
                Console.WriteLine("4. Animal List");
                Console.WriteLine("5. Transfer");

                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        AddAnimalMenu();
                        break;
                    case 2:
                        DeleteAnimalMenu();
                        break;
                    case 3:
                        AnimalSpeak();
                        break;
                    case 4:
                        AnimalList();
                        break;
                    case 5:
                        AnimalTransfer();
                        break;
                }
            }
        }
        Dog a = new Dog();
        Cat c = new Cat();
        Lion l = new Lion();
        Tiger t = new Tiger();
        Horse h = new Horse();

    }

    class Program
    {
        static void Main(string[] args)
        {
            ZooMgr m = new ZooMgr();
            m.Menu();
        }
    }
}