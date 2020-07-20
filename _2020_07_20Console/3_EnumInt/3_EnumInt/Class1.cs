using System;
using System.Collections.Generic;
using System.Text;

namespace _2020_07_20Console._3_EnumInt._3_EnumInt
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. 봄");
            Console.WriteLine("2. 여름");
            Console.WriteLine("3. 가을");
            Console.WriteLine("4. 겨울");
            Console.WriteLine();
            Console.WriteLine("번호 선택 >> ");


            int num = Int32.Parse(Console.ReadLine());
        }
    }
} 
