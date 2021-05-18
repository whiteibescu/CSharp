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
    class MemberMgr
    {
        public void InputMember()
        //                                          MemberMgr this
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
                Member m = (Member)MemList[i];
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
        public void ModifyMember()
        {
            Console.Write("수정하려는 이름 : ");
            string SearchName = Console.ReadLine();
            Member m = FindMember(SearchName);
            if (m != null)
            {
                m.ModifyData();
            }
            else
            {
                Console.WriteLine("수정하려는 데이터는 없습니다.");
            }
        }
        public void DeleteMember()
        {
            Console.Write("삭제하려는 이름 : ");
            string SearchName = Console.ReadLine();
            int iIndex = FindMemberIndex(SearchName);
            if (iIndex != -1)
            {
                MemList.RemoveAt(iIndex);
            }
            else
            {
                Console.WriteLine("삭제하려는 데이터는 없습니다.");
            }
        }
        public ArrayList FindMultiMemberIndex(string SearchName)
        {
            ArrayList Result = new ArrayList();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.ContainName(SearchName))
                {
                    Result.Add(i);
                }
            }
            return Result;
        }
        public void PrintMember(ArrayList iIndexList)
        {
            for (int i = 0; i < iIndexList.Count; i++)
            {
                Member m = (Member)MemList[(int)iIndexList[i]];
                m.PrintData();
            }
        }
        public void MultiSearchMember()
        {
            Console.Write("찾으려는 이름 문자열: ");
            string SearchName = Console.ReadLine();
            ArrayList iIndexList = FindMultiMemberIndex(SearchName);
            if (iIndexList.Count > 0)
            {
                PrintMember(iIndexList);
            }
            else
            {
                Console.WriteLine("찾으려는 데이터는 없습니다.");
            }
        }
        public void DeleteMember(ArrayList iIndexList)
        {
            for (int i = iIndexList.Count - 1; i >= 0; i--)
            {
                MemList.RemoveAt((int)iIndexList[i]);
            }
        }
        public void MultiDeleteMember()
        {
            Console.Write("삭제하려는 이름 문자열: ");
            string SearchName = Console.ReadLine();
            ArrayList iIndexList = FindMultiMemberIndex(SearchName);
            if (iIndexList.Count > 0)
            {
                DeleteMember(iIndexList);
            }
            else
            {
                Console.WriteLine("삭제하려는 데이터는 없습니다.");
            }
        }
        public void Menu()

        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("2. 회원출력");
                Console.WriteLine("3. 회원검색");
                Console.WriteLine("4. 회원수정");
                Console.WriteLine("5. 회원삭제");
                Console.WriteLine("6. 다중검색");
                Console.WriteLine("7. 다중삭제");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 0:
                        break;
                    case 1:
                        {
                            InputMember();
                        }
                        break;
                    case 2:
                        {
                            PrintMember();
                        }
                        break;
                    case 3:
                        {
                            SearchMember();
                        }
                        break;
                    case 4:
                        {
                            ModifyMember();
                        }
                        break;
                    case 5:
                        {
                            DeleteMember();
                        }
                        break;
                    case 6:
                        {
                            MultiSearchMember();
                        }
                        break;
                    case 7:
                        {
                            MultiDeleteMember();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private ArrayList MemList = new ArrayList();
    }
    class Program
    {
        static void Main(string[] args)
        {
            MemberMgr m = new MemberMgr();
            m.Menu();
        }
    }
}