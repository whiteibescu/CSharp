using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay04
{
    class Member
    {
        public void InputData()
        //                                     Member this = 2100
        {
            Console.Write("이름 : ");
            this.m_MemName = Console.ReadLine();
            Console.Write("주소 : ");
            this.m_MemAddr = Console.ReadLine();
            Console.Write("전화번호 : ");
            this.m_MemTelNo = Console.ReadLine();
        }
        public void PrintData()
        //                                    Member this = 1100
        {
            Console.WriteLine("이름 : {0}", m_MemName);
            Console.WriteLine("주소 : {0}", m_MemAddr);
            Console.WriteLine("전화번호 : {0}", m_MemTelNo);
        }

        public bool CompareName(string SearchName)
        {
            return m_MemName == SearchName;
        }

        public void CompareAllNames(string SearchName)
        {
            char[] searchName = SearchName.ToCharArray();
            Console.WriteLine("되냐 {0}", SearchName);
            Console.WriteLine("char로 간다", searchName[0]);
            Console.WriteLine("char로 간다", searchName[1]);
            Console.WriteLine("char로 간다", searchName[2]);
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
            m.InputData();
            MemList.Add(m);
        }
        public void PrintMember()
        {
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                m.PrintData();
            }
        }

        public void SearchAllMembers()
        {
            /*          Member m = new Member();
                        string check = Console.ReadLine();
                        m.CompareAllNames(check);*/
            Console.WriteLine("구현중입니다. 다른 메뉴를 선택해주세요~");
        }


        public void DeleteAllMembers()
        {
            Console.WriteLine("구현중입니다. 다른 메뉴를 선택해주세요~");
        }

        public void SearchMember()
        {
            Console.WriteLine("검색하실 이름을 입력해주세요! : ");
            string check = Console.ReadLine();

            for (int i = 0; i < MemList.Count; ++i)
            {
                Member m = (Member)MemList[i];
                
                if (m.CompareName(check))
                {
                    m.PrintData();
                    return;
                }
            }
            Console.WriteLine("찾으려는 데이터는 없습니다");
        }
        public void DeleteMember()  
        {
            Console.WriteLine("삭제하실 이름을 입력해주세요! : ");
            string check = Console.ReadLine();
            
            for (int i = 0; i < MemList.Count; ++i)
            {
                Member m = (Member)MemList[i];
                if (m.CompareName(check))
                {
                    MemList.RemoveAt(i);
                    Console.WriteLine("삭제 완료하였습니다.");
                    return;
                }
            }
            Console.WriteLine("찾으려는 데이터는 없습니다");
        }

        public void EditMember()
        {
            Console.WriteLine("수정하실 이름을 입력해주세요! : ");
            string check = Console.ReadLine();
            for (int i = 0; i < MemList.Count; ++i)
            {
                Member m = (Member)MemList[i];
                if (m.CompareName(check))
                {
                    MemList.RemoveAt(i);
                    m.InputData();
                    MemList.Insert(i, m);
                    Console.WriteLine("수정 완료하였습니다.");
                    return;
                }
            }
            Console.WriteLine("찾으려는 데이터는 없습니다");
        }
        public void Menu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 회원등록");
                Console.WriteLine("2. 회원출력");
                Console.WriteLine("3. 회원검색");
                Console.WriteLine("4. 회원삭제");
                Console.WriteLine("5. 회원수정");
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
                            DeleteMember();
                        }
                        break;
                    case 5:
                        {
                            EditMember();
                        }
                        break;
                    case 6:
                        {
                            SearchAllMembers();
                        }
                        break;
                    case 7:
                        {
                            DeleteAllMembers();
                        }
                        break;
                        
                    default:
                        {
                            Console.WriteLine("잘못 입력하셨습니다.");
                        }
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
            MemberMgr mgr = new MemberMgr();
            mgr.Menu();
        }
    }
}