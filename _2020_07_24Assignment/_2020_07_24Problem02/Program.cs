using System;
using System.Linq;

namespace _2020_07_24Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("영문자를 입력해주세요 : ");
            string input = "";
            foreach (char ch in Console.ReadLine()) 
            {
                input += ch >= 97 && ch <= 122 ? (char)(ch - 32) : (char)(ch + 32); // 숫자를 더하거나 빼게되면 바로 int 자동 캐스팅
            }
        }
    }
}
