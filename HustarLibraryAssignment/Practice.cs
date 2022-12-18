using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test13
{
    delegate bool CompareFuncDele(string str);
    class Book
    {
        public bool CompareISBN(string str)
        {
            return m_ISBNCode == str;
        }
        public bool CompareTitle(string str)
        {
            return m_Title == str;
        }
        public bool CompareAuthor(string str)
        {
            for (int i = 0; i < m_authors.Count; i++)
            {
                if (str == m_authors[i])
                {
                    return true;
                }
            }
            return false;
        }
        public bool CompareFunc(string str, CompareFuncDele compFunc)
        {
            return compFunc(str);
        }
        public string m_ISBNCode;
        public string m_Title;
        public List<string> m_authors = new List<string>();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.m_Title = "홍길동";
            b.m_ISBNCode = "123";
            b.m_authors.Add("1");
            b.m_authors.Add("2");
            b.m_authors.Add("3");
            b.m_authors.Add("4");
            var iChoice = int.Parse(Console.ReadLine());
            switch (iChoice)
            {
                case 1:
                    b.CompareFunc("홍길동", b.CompareTitle)
                    break;
                case 2:
                    break;
                case 3:
                    break;
                default:
                    break;
            }
            if (b.CompareFunc("홍길동", b.CompareTitle))
            {
                Console.WriteLine("홍길동 Found");
            }
            if (b.CompareFunc("123", b.CompareISBN))
            {
                Console.WriteLine("123 Found");
            }
            if (b.CompareFunc("5", b.CompareAuthor))
            {
                Console.WriteLine("3 Found");
            }
        }
    }
}