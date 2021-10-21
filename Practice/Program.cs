using System;

namespace Practice
{
    class Program
    {
        static int money = 1260;
        static int coin_cnt = 0;
        static int[] coin_type = new int[] { 1000, 500, 100, 50, 10};
        static int cjsdnjs = 1000;

        static void Main(string[] args)
        {
            foreach (int coin in coin_type)
            {
                coin_cnt += money / coin; //1
                money %= coin; //1
            }

            Console.WriteLine("동전갯수: {0}", coin_cnt);
        }
    }
}
