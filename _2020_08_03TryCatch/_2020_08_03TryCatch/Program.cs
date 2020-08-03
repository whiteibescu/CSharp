using System;

namespace _2020_08_03TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue, y = 0;
                //int num;
                //Console.WriteLine("정수를 입력하세요");
                //num = Int32.Parse(Console.ReadLine());
            
            try
            {
                //Console.WriteLine(x);
                y = x + 10;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }           
        }
    }
}
