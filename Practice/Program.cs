using System;
using System.Collections.Generic;
using System.Text;

namespace BookManager
{
    delegate bool StringCompareDelegate(string str1, string str2);
    delegate bool CompareBookDelegate(Book book, string str);

    static class BookUtil
    {
        public static int GetInputInt()
        {
            int iChoice = 0;
            while (true)
            {
                try
                {
                    iChoice = int.Parse(Console.ReadLine());
                    return iChoice;
                }
                catch (Exception)
                {
                    Console.WriteLine("숫자값을 입력하세요...");
                }
            }
        }

        public static string InputString(string strTitle)
        {
            Console.Write(strTitle);
            return Console.ReadLine();
        }

        public static List<string> InputList(string strTitle)
        {
            List<string> strList = new List<string>();
            int iIndex = 1;
            while (true)
            {
                Console.Write($"{strTitle}{iIndex} : ");
                string strString = Console.ReadLine();
                if (strString == "")
                {
                    return strList;
                }
                ++iIndex;
                strList.Add(strString);
            }
        }
        public static void PrintList(string strTitle, List<string> strList)
        {
            for (int i = 0; i < strList.Count; i++)
            {
                Console.WriteLine($"{strTitle}{i + 1} : {strList[i]}");
            }
        }

        public static bool StringEqual(string str1, string str2)
        {
            return str1 == str2;
        }

        public static bool StringContains(string str1, string str2)
        {
            return str1.Contains(str2);
        }

        public static bool SearchInList(List<string> strList, string str, StringCompareDelegate compareDelegate)
        {
            for (int i = 0; i < strList.Count; i++)
            {
                if (compareDelegate(strList[i], str))
                {
                    return true;
                }
            }
            return false;
        }
    }

    interface IBookMgr
    {
        int SearchBook(string strISBN, CompareBookDelegate compareBookDelegate);
    }

    class Book
    {
        public void ModifyData()
        {
            m_BookTitle = BookUtil.InputString("책 제목");
            m_ISBN = BookUtil.InputString("저자");

        }
        public bool InputData(IBookMgr bookMgr)
        {
            m_ISBN = BookUtil.InputString("ISBN : ");
            if (bookMgr.SearchBook(m_ISBN, Book.CompareISBN) != -1)
                ModifyData();
            return true;
        }
        public void PrintData()
        {
            Console.WriteLine("ISBN : {0}", m_ISBN);
            Console.WriteLine("책제목 : {0}", m_BookTitle);
            BookUtil.PrintList("저자", m_BookAuthors);
            BookUtil.PrintList("목차", m_BookContents);
            Console.WriteLine("출판사 : {0}", m_BookPublisher);
        }
        public static bool CompareISBN(Book book, string strISBN)
        {
            return book.m_ISBN == strISBN;
        }
        public static bool CompareBookTitle(Book book, string strTitle)
        {
            return book.m_BookTitle == strTitle;
        }
        public static bool FindAuthor(Book book, string strAuthor)
        {
            return BookUtil.SearchInList(book.m_BookAuthors, strAuthor, BookUtil.StringEqual);
        }
        public static bool FindContents(Book book, string strContents)
        {
            return BookUtil.SearchInList(book.m_BookContents, strContents, BookUtil.StringContains);
        }
        public string GetTitleAndAuthors()
        {
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append("책제목 : ");
            strBuilder.Append(m_BookTitle);
            strBuilder.Append("저자 : ");
            for (int i = 0; i < m_BookAuthors.Count; i++)
            {
                strBuilder.Append(m_BookAuthors[i]);
                strBuilder.Append(",");
            }
            return strBuilder.ToString();
        }

        

        private string m_BookTitle;
        private string m_ISBN;
        private List<string> m_BookAuthors;
        private List<string> m_BookContents;
        private string m_BookPublisher;
    }
    class BookManager : IBookMgr
    {
        public void InsertBook()
        {
            Book b = new Book();
            if (b.InputData(this))
            {
                m_BookList.Add(b);
            }
        }
        public void PrintAllBooks()
        {
            for (int i = 0; i < m_BookList.Count; i++)
            {
                m_BookList[i].PrintData();
            }
        }
        public void PrintAllBooks(List<int> ResultList)
        {
            for (int i = 0; i < ResultList.Count; i++)
            {
                m_BookList[ResultList[i]].PrintData();
            }
        }
        public int SearchBook(string strISBN, CompareBookDelegate compareBookDelegate)
        {
            for (int i = 0; i < m_BookList.Count; i++)
            {
                if (compareBookDelegate(m_BookList[i], strISBN))
                {
                    return i;
                }
            }
            return -1;
        }
        public void SearchBook(string strTitle, string strErrMsg, CompareBookDelegate compareBookDelegate)
        {
            string str = BookUtil.InputString(strTitle);
            int iIndex = SearchBook(str, compareBookDelegate);
            if (iIndex != -1)
            {
                m_BookList[iIndex].PrintData();
            }
            else
            {
                Console.WriteLine(strErrMsg);
            }
        }
        public List<int> SearchInList(string str, CompareBookDelegate compareBookDelegate)
        {
            List<int> ResultList = new List<int>();
            for (int i = 0; i < m_BookList.Count; i++)
            {
                if (compareBookDelegate(m_BookList[i], str))
                {
                    ResultList.Add(i);
                }
            }
            return ResultList;
        }

        public void SearchInList(string strTitle, string strErrMsg, CompareBookDelegate compareBookDelegate)
        {
            string strAuthor = BookUtil.InputString(strTitle);
            List<int> ResultList = SearchInList(strAuthor, compareBookDelegate);
            if (ResultList.Count > 0)
            {
                PrintAllBooks(ResultList);
            }
            else
            {
                Console.WriteLine(strErrMsg);
            }
        }

        public void SearchBookMenu()
        {
            int iChoice = 1;
            while (iChoice != 0)
            {
                Console.WriteLine("1. ISBN으로 검색");
                Console.WriteLine("2. 책제목으로 검색");
                Console.WriteLine("3. 저자로 검색");
                Console.WriteLine("4. 목차로 검색");
                Console.WriteLine("5. 종료");
                iChoice = BookUtil.GetInputInt();
                switch (iChoice)
                {
                    case 1:
                        SearchBook("찾을 ISBN코드 : ", "찾으려는 ISBN코드 도서는 존재하지 않습니다.", Book.CompareISBN);
                        break;
                    case 2:
                        SearchInList("찾을 책제목 : ", "찾으려는 제목의 도서는 존재하지 않습니다.", Book.CompareBookTitle);
                        break;
                    case 3:
                        SearchInList("찾으려는 저자 : ", "찾으려는 저자의 도서는 존재하지 않습니다.", Book.FindAuthor);
                        break;
                    case 4:
                        SearchInList("찾으려는 목차 문자열 : ", "찾으려는 목차의 문자열 도서는 존재하지 않습니다.", Book.FindContents);
                        break;
                    default:
                        break;
                }
            }
        }

        public int DisplayTitleAndAuthorsList(List<int> Result)
        {
            for (int i = 0; i < Result.Count; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, m_BookList[Result[i]].GetTitleAndAuthors());
            }
            int iChoice = BookUtil.GetInputInt();
            if (iChoice > 0 && iChoice <= Result.Count)
            {
                return iChoice - 1;
            }
            return -1;
        }

        private List<Book> m_BookList = new List<Book>();
    }
}