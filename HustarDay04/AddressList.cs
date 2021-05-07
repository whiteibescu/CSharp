using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HustarDay04
{
    class Member
    {
        public void InputData()
        {
            Console.Write("이름:");
            m_MemName = Console.ReadLine();
            Console.Write("주소 : ");
            m_MemAdd = Console.ReadLine();
            Console.Write("전화번호 : ");
            m_MemTelNo = Console.ReadLine(); ;
        }
        public void PrintData()
        {
            Console.WriteLine("이름 : {0}", m_MemName);
            Console.WriteLine("주소 : {0}", m_MemAdd);
            Console.WriteLine("전화번호 : {0}", m_MemTelNo);
        }
        private string m_MemName;
        private string m_MemAdd;
        private string m_MemTelNo;
    }
    class AddressList
    {
        static void Main(string[] args)
        {
            ArrayList MemList = new ArrayList();
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1.회원등록");
                Console.WriteLine("2.회원출력");
            }
            for (int i = 0; i < 2; ++i)
            {
                Member m1 = new Member();
                m1.InputData();
                MemList.Add(m1); //오브젝트를 받는다
            }
            for (int i = 0; i < MemList.Count; ++i)
            {
                Member m1 = (Member)MemList[i];
                m1.PrintData();
            }
        }
    }
}
