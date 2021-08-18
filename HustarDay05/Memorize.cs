using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalAddressList
{
    class Member
    {
        public bool InputData(MemberMgr mgr)
        {
            Console.Write("이름 :");
            if (mgr.FindMember(m_MemName != null))
            {
                return false;
            }
            ModifyData();
            return true;
        }

        public void ModifyData()
        {
            Console.Write("주소 :");
            m_MemAddr = Console.ReadLine();
            Console.Write("전화번호 : ");
            m_MemName = Console.ReadLine();
        }

        public void PrintData()
        {
            Console.WriteLine("이름 : ", m_MemName);
            Console.WriteLine("주소 : ", m_MemAddr);
            Console.WriteLine("전화번호 : ", m_MemTelNo);
        }

        public bool CompareName(string SearchName)
        {
            return m_MemName == SearchName;
        }

        public bool ContainName(string SearchName)
        {
            return m_MemName.Contains(SearchName);
        }

        private string m_MemName;
        private string m_MemAddr;
        private string m_MemTelNo;

        class MemberMGr
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
                    Console.WriteLine("이미 등록된 회원입니다.");
                }
            }
            public void PrintMember()
            {
                for (int i = 0; i < MemList.Count; i++)
                {
                    Member m = (Member)MemList[(int)iIndexList[i]];
                    m.PrintData();
                }
            }
            public int FindMemberIndex(string SearchName)
            {
                for (int i = 0; i < MemList.Count; i++)
                {
                    Member m = (Member)MemList[i];
                    if (m.CompareName(SearchName))
                    {
                        return i;
                    }
                }
                return -1;
            }
            public Member FindMember(string SearchName)
            {
                int iIndex = FindMemberIndex(SearchName);
                if (iIndex != -1)
                {
                    return (Member)MemList[iIndex];
                }
                return null;
            }
            public void SearchMember()
            {
                Console.Write("찾으려는 이름 : ");
                string SearchName = Console.ReadLine();
                Member m = FindMember(SearchName);
                if (m != null)
                {
                    m.PrintData();
                }
                else
                {
                    Console.WriteLine("찾으려는 데이터는 없습니다.");
                }
            }













            public void MultiSearchMember()
            {

            }
            private ArrayList MemList = new ArrayList();
        }
    }
}