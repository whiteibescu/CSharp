using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarLibraryAssignment
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
                    iChoice = int.Parse(Console.ReadLine);
                    return iChoice
                }
            }
        }
    }




    class Practice
    {
        
    }
}
