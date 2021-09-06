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
            Console.Write("이름 : ");
            m_MemName = Console.ReadLine();
            if (mgr.FindMember(m_MemName) != null)
            {
                return false;
            }
            ModifyData();
            return true;
        }
        public void ModifyData()
        {
            Console.Write("주소 : ");
            m_MemAddr = Console.ReadLine();
            Console.Write("전화번호 : ");
            m_MemTelNo = Console.ReadLine();
        }
        public void PrintData()
        {
            Console.WriteLine("이름 : {0}", m_MemName);
            Console.WriteLine("주소 : {0}", m_MemAddr);
            Console.WriteLine("전화번호 : {0}", m_MemTelNo);
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
    }
}