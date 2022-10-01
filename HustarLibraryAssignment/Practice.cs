using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test13
{
    delegate bool CompareFuncDele(Book b, string str);
    class Book
    {
        public static bool CompareISBN(Book b, string str)
        {
            return b.m_ISBNCode == str;
        }
        public static bool CompareTitle(Book b, string str)
        {
            return b.m_Title == str;
        }
        public static bool CompareAuthor(Book b, string str)
        {
            for (int i = 0; i < b.m_authors.Count; i++)
            {
                if (str == b.m_authors[i])
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CompareFunc(string str, Book b, CompareFuncDele compFunc)
        {
            return compFunc(b, str);
        }
        public void PrintData()
        {
            Console.WriteLine("ISBN : {0}", m_ISBNCode);
            Console.WriteLine("Title : {0}", m_Title);
        }
        public string m_ISBNCode;
        public string m_Title;
        public List<string> m_authors = new List<string>();
    }
    class BookMgr
    {
        public BookMgr()
        {
            Book b1 = new Book() { m_Title = "1", m_ISBNCode = "123" };
            b1.m_authors.Add("1");
            b1.m_authors.Add("2");
            b1.m_authors.Add("3");
            b1.m_authors.Add("4");
            Book b2 = new Book() { m_Title = "2", m_ISBNCode = "234" };
            b2.m_authors.Add("2");
            b2.m_authors.Add("3");
            b2.m_authors.Add("4");
            b2.m_authors.Add("5");
            Book b3 = new Book() { m_Title = "3", m_ISBNCode = "345" };
            b2.m_authors.Add("3");
            b2.m_authors.Add("4");
            b2.m_authors.Add("5");
            b2.m_authors.Add("6");
            m_BookList.Add(b1);
            m_BookList.Add(b2);
            m_BookList.Add(b3);
        }
        public void InputBook()
        {
            Book b1 = new Book();
        }
        public Book SearchFunc(string strTitle, CompareFuncDele compFunc)
        {
            Console.WriteLine(strTitle);
            string str = Console.ReadLine();
            for (int i = 0; i < m_BookList.Count; i++)
            {
                if (compFunc(m_BookList[i], str))
                {
                    m_BookList[i].PrintData();
                    return m_BookList[i];
                }
            }
            Console.WriteLine("찾으려는 데이터는 없습니다.");
            return null;
        }
        public void SearchBook()
        {
            Console.WriteLine("1. 책제목으로 검색");
            Console.WriteLine("2. ISBN으로 검색");
            Console.WriteLine("3. 저자로 검색");
            int iChoice = int.Parse(Console.ReadLine());
            switch (iChoice)
            {
                case 1:
                    SearchFunc("책제목", Book.CompareTitle);
                    break;
                case 2:
                    SearchFunc("ISBN", Book.CompareISBN);
                    break;
                case 3:
                    SearchFunc("저자", Book.CompareAuthor);
                    break;
            }
        }
        private List<Book> m_BookList = new List<Book>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            BookMgr m = new BookMgr();
            m.SearchBook();
        }
    }
}