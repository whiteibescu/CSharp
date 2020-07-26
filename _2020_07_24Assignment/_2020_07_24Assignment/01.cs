using System;
using System.Linq;

namespace _2020_07_24Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("영문자를 입력해주세요 : ");
            string input = Console.ReadLine();

            Console.WriteLine(input.Any(char.IsUpper) ? "대문자" : "소문자");


/*            if (input.Any(char.IsUpper))
            {
                Console.WriteLine(input);
            }
            else
            {
                Console.WriteLine("소문자입니다 :" + input);
            }*/
        }
    }
}
