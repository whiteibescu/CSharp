using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarLibraryAssignment
{
    class Member
    {
        public void InputData()
        {
            Console.WriteLine("ISBN을 입력해주세요 : ");
            m_MemIsbn = Console.ReadLine();
            Console.WriteLine("책 제목을 입력해주세요 : ");
            m_MemTitle = Console.ReadLine();
            Console.WriteLine("출판사를 입력해주세요 : ");
            m_MemPublisher = Console.ReadLine();
            InputAuthorData();
            InputIndexData();
        }
        public void InputAuthorData()
        {
            string author = "저자";
            InputVar(AuthorList, author);
        }

        public void InputIndexData()
        {
            string index = "목차";
            InputVar(IndexList, index);
        }

        public void InputVar(ArrayList List, string text)
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("{0}를 입력해주세요 : ", text);
                string data = Console.ReadLine();

                if (data == "")
                {
                    return;
                }
                List.Add(data);                                
            }
        }

        public void SearchCount(ArrayList list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("저자 {0}: {1}", i + 1, list[i]);
            }
        }


        public void PrintData()
        {
            Console.WriteLine("ISBN : {0}", m_MemIsbn);
            Console.WriteLine("책 제목 : {0}", m_MemTitle);
            Console.WriteLine("출판사 : {0}", m_MemPublisher);
            SearchCount(AuthorList);
            SearchCount(IndexList);
        }

        public bool CompareTitle(string SearchTitle)
        {
            return m_MemTitle == SearchTitle;
        }
        public bool CompareISBN(string SearchISBN)
        {
            return m_MemIsbn == SearchISBN;
        }
        public bool CompareAuthor(string SearchAuthor)
        {
            for (int i = 0; i < AuthorList.Count; i++)
            {
                return (string)AuthorList[i] == SearchAuthor;
            }
            return false;
        }

        public bool CompareIndex(string SearchIndex)
        {
            for (int i = 0; i < IndexList.Count; i++)
            {
                return (string)IndexList[i] == SearchIndex;
            }
            return false;
        }

        private string m_MemTitle;
        private string m_MemIsbn;
        private string m_MemPublisher;
        ArrayList AuthorList = new ArrayList();
        ArrayList IndexList = new ArrayList();
    }

    class LibraryMgr
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

        public int FindMemberIndex(string Search)
        {
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareTitle(Search))
                {
                    return i;
                }
            }
            return -1;
        }

        public Member FindMember(string Search)
        {
            int iIndex = FindMemberIndex(Search);
            if (iIndex != -1)
            {
                return (Member)MemList[iIndex];
            }
            return null;
        }

        public void SearchByTitle()
        {
            Console.WriteLine("제목을 입력해주세요 : ");
            string SearchTitle = Console.ReadLine();
            Member m = FindMember(SearchTitle);
            if (m != null)
            {
                m.PrintData();
            }
            else
            {
                Console.WriteLine("찾으려는 데이터가 없습니다.");
            }
        }



        public Member SearchByAuthor()
        {
            Console.WriteLine("저자 검색");
            string SearchAuthor = Console.ReadLine();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareAuthor(SearchAuthor)) //true or false
                {
                    m.PrintData();
                }
                else
                {
                    Console.WriteLine("찾으려는 데이터가 없습니다.");
                }
            }
            return null;
        }

        public Member SearchByIndex()
        {
            Console.WriteLine("목차 검색");
            string SearchIndex = Console.ReadLine();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareIndex(SearchIndex))
                {
                    m.PrintData();
                }
                else
                {
                    Console.WriteLine("찾으려는 데이터가 없습니다.");
                }
            }
            return null;
        }

        public void SearchMemberMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 책 제목으로 검색");
                Console.WriteLine("2. 저자로 검색");
                Console.WriteLine("3. 목차로 검색");
                Console.WriteLine("4. 메뉴로 돌아가기");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        SearchByTitle();
                        break;
                    case 2:
                        SearchByAuthor();
                        break;
                    case 3:
                        SearchByIndex();
                        break;
                    case 4:
                        iChoice = 0;
                        break;
                }

            }
        }

        public void DeleteMemberMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 책 제목으로 검색후 삭제");
                Console.WriteLine("2. 저자로 검색후 삭제");
                Console.WriteLine("3. 목차로 검색후 삭제");
                Console.WriteLine("4. 메뉴로 돌아가기");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        DeleteByTitle();
                        break;
                    case 2:
                        DeleteByAuthor();
                        break;
                    case 3:
                        DeleteByIndex();
                        break;
                    case 4:
                        iChoice = 0;
                        break;
                }
            }
        }

        public void DeleteByTitle()
        {
            PrintMember();
            Console.WriteLine("삭제하려는 제목을 입력하세요 : ");
            string DeleteTitle = Console.ReadLine();
            int iIndex = FindMemberIndex(DeleteTitle);
            if (iIndex != -1)
            {
                MemList.RemoveAt(iIndex);
                Console.WriteLine("{0} 삭제 완료되었습니다. ", DeleteTitle);
            }
            else
            {
                Console.WriteLine("삭제하려는 데이터가 없습니다.");
            }
        }

        public void DeleteFunc(ArrayList iIndexList)
        {
            if (iIndexList.Count > 0)
            {
                for (int i = iIndexList.Count - 1; i >= 0; i--)
                {
                    MemList.RemoveAt((int)iIndexList[i]);
                }
            }
            else
            {
                Console.WriteLine("삭제하려는 데이터가 없습니다. ");
            }
        }
        public void DeleteByAuthor()
        {
            PrintMember();
            Console.WriteLine("삭제하려는 저자를 입력하세요: ");
            string DeleteAuthor = Console.ReadLine();
            ArrayList iIndexList = FindMultiAuthorIndex(DeleteAuthor);
            DeleteFunc(iIndexList);
        }

        public void DeleteByIndex()
        {
            PrintMember();
            Console.WriteLine("삭제하려는 목차를 입력하세요: ");
            string DeleteIndex = Console.ReadLine();
            ArrayList iIndexList = FindMultiIndexIndex(DeleteIndex);
            DeleteFunc(iIndexList);
        }

        public ArrayList FindMultiAuthorIndex(string DeleteAuthor)
        {
            ArrayList Result = new ArrayList();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareAuthor(DeleteAuthor))
                {
                    Result.Add(i);
                }
            }
            return Result;
        }

        public ArrayList FindMultiIndexIndex(string IndexAuthor)
        {
            ArrayList Result = new ArrayList();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareIndex(IndexAuthor))
                {
                    Result.Add(i);
                }
            }
            return Result;
        }

        public void ModifyMemberMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. 책 제목으로 검색후 수정");
                Console.WriteLine("2. 저자로 검색후 수정");
                Console.WriteLine("3. 목차로 검색후 수정");
                Console.WriteLine("4. 메뉴로 돌아가기");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        ModifyByTitle();
                        break;
                    case 2:
                        ModifyByAuthor();
                        break;
                    case 3:
                        ModifyByIndex();
                        break;
                    case 4:
                        iChoice = 0;
                        break;
                }
            }
        }

        public void ModifyByTitle()
        {
            Console.WriteLine("수정하려는 책 제목을 입력해주세요 : ");
            string SearchTitle = Console.ReadLine();
            Member m = FindMember(SearchTitle);
            if (m != null)
            {
                m.InputData();
            }
            else
            {
                Console.WriteLine("찾으려는 데이터가 없습니다.");
            }
        }

        public void ModifyByAuthor()
        {
            Console.WriteLine("수정하려는 저자를 입력해주세요 : ");
            string SearchAuthor = Console.ReadLine();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareAuthor(SearchAuthor))
                {
                    m.InputData();
                }
                else
                {
                    Console.WriteLine("찾으려는 데이터가 없습니다.");
                }
            }
        }

        public void ModifyByIndex()
        {
            Console.WriteLine("수정하려는 목차를 입력해주세요 : ");
            string SearchIndex = Console.ReadLine();
            for (int i = 0; i < MemList.Count; i++)
            {
                Member m = (Member)MemList[i];
                if (m.CompareIndex(SearchIndex))
                {
                    m.InputData();
                }
                else
                {
                    Console.WriteLine("찾으려는 데이터가 없습니다.");
                }
            }
        }

        public void MainMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("도서관리에 오신것을 환영합니다");
                Console.WriteLine("1.도서입력");
                Console.WriteLine("2.도서출력");
                Console.WriteLine("3.도서검색");
                Console.WriteLine("4.도서삭제");
                Console.WriteLine("5.도서수정");
                Console.WriteLine("0.종료");
                iChoice = int.Parse(Console.ReadLine());
                switch (iChoice)
                {
                    case 1:
                        InputMember();
                        break;
                    case 2:
                        PrintMember();
                        break;
                    case 3:
                        SearchMemberMenu();
                        break;
                    case 4:
                        DeleteMemberMenu();
                        break;
                    case 5:
                        ModifyMemberMenu();
                        break;
                    default:
                        break;
                }
            }
        }
        private ArrayList MemList = new ArrayList();
    }
    class Library
    {
        static void Main(string[] args)
        {
            LibraryMgr l = new LibraryMgr();
            l.MainMenu();
        }
    }
}

