using System;

namespace _2020_07_23Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("정수를 입력해주세요 : ");
            string Input = Console.ReadLine();
            int num = Convert.ToInt32(Input);
            
            for (int i = 0; i < num; ++i)
            {
                Console.WriteLine(3 * (i+1));
            }
        } 
    }
}



