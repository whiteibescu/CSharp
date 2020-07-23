using System;

namespace _2020_07_23_Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int i;

            Console.WriteLine("원하시는 구구단은? 역순행!!");
            string input = Console.ReadLine();
            a = Convert.ToInt32(input);

            for(i=9; i>=1; --i)
            {
                Console.WriteLine(a + " x " + i + " = " + a * i + "\t");
            }    
        }
    }
}
