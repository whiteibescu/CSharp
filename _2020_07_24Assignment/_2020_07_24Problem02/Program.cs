using System;
using System.Linq;

namespace _2020_07_24Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("영문자를 입력해주세요 : ");
            string input = Console.ReadLine();

            if (65 <= input & input <= 90)
            {

                input += 32;
                Console.WriteLine(input);

            }
            else if (97 <= input & input <= 122)
            {

                input -= 32;
                Console.WriteLine(input);



            }
        }
    }
}
