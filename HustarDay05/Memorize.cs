using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;

namespace HustarDay05
{
    class Member
    {
        public bool InputData(MemberMgr mgr)
        {
            Console.Write("이름 : ");
            m_MemName = Console.ReadLine();
            if (mgr.FindMember(m_MemName) != null)
            {
                return false;
            }
            ModifyData();
            return true;
        }

        public void PrintData()
        {
            Console.WriteLine("이름 : {0}", m_MemName);
            Console.WriteLine("주소 : {0}", m_MemAddr);
            Console.WriteLine("전화번호 : {0}", m_MemTelNo);
        }

        public void ModifyData()
        {
            Console.Write("주소 : ");
            m_MemAddr = Console.ReadLine();
            Console.Write("번호 : ");
            m_MemTelNo = Console.ReadLine();
        }

        public bool CompareName(string SearchName)
        {
            return SearchName == m_MemName;
        }

        public bool ContainName(string SearchName)
        {
            return m_MemName.Contains(SearchName);
        }




        private string m_MemName;
        private string m_MemAddr;
        private string m_MemTelNo;


    }

    class MemberMgr
    {
        public void InputMember()
        {
            Member m = new Member();
            if (m.InputData(this) == true)
            {
                MemList.Add(m);
            }
            else
            {
                Console.WriteLine("등록된 회원이 있습니다.");
            }
        }

        public void PrintMember()
        {
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                m.PrintData();
            }
        }

        public void Menu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("1. 회원등록");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        InputMember();
                        break;
                    case 2:
                        PrintData();
                        break;
                    case 3:
                        ModifyData();
                }

            }
        }
        private ArrayList MemList = new ArrayList();
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
