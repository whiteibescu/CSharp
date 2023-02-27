using System;
using System.Collections.Generic;

namespace Delegate
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


        public string m_ISBNCode;
        public string m_Title;
        public List<string> m_authors = new List<string>();

    }
}