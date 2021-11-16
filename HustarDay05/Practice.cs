using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
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
            return true();
        }

        public void ModifyData()
        {
            Console.Write("주소 : ");
            
        }
        private string m_MemName;
        private string m_MemAddr;
        private string m_MemTelNo;
    }

    class MemberMgr
    {

    }
}