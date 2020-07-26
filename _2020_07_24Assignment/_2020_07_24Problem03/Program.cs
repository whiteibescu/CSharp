using System;
using System.Data.SqlTypes;

namespace _2020_07_24Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("돈의 액수를 입금하세요 :");
            int sum = Convert.ToInt32(Console.ReadLine());
            int fiftyT = 0, tenT = 0, fiveT = 0, oneT = 0, fiveH = 0, oneH = 0,
                fifty = 0, ten = 0, one = 0;

            while (sum != 0)
            {
                if (sum >= 50000)
                {
                    fiftyT += 1;
                    sum -= 50000;
                }
                else if (sum >= 10000)
                {
                    tenT += 1;
                    sum -= 10000;
                }
                else if (sum >= 5000)
                {
                    fiveT += 1;
                    sum -= 5000;
                }
                else if (sum >= 1000)
                {
                    oneT += 1;
                    sum -= 1000;
                }
                else if (sum >= 500)
                {
                    fiveH += 1;
                    sum -= 500;
                }
                else if (sum >= 100)
                {
                    oneH += 1;
                    sum -= 100;
                }
                else if (sum >= 50)
                {
                    fifty += 1;
                    sum -= 50;
                }
                else if (sum >= 10)
                {
                    ten += 1;
                    sum -= 10;
                }
                else
                {
                    one = sum;
                    sum = 0;
                }
            }
            if (fiftyT > 0)
            {
                Console.WriteLine("오만원" + fiftyT + "장");
            }
            if (tenT > 0)
            {
                Console.WriteLine("만원" + tenT + "장");
            }
            if (fiveT > 0)
            {
                Console.WriteLine("오천원" + fiveT + "장");
            }
            if (oneT > 0)
            {
                Console.WriteLine("천원" + oneT + "장");
            }
            if (fiveH > 0)
            {
                Console.WriteLine("오백원" + fiveH + "개");
            }
            if (oneH > 0)
            {
                Console.WriteLine("백원" + oneH + "개");
            }
            if (fifty > 0)
            {
                Console.WriteLine("오십원" + fifty + "개");
            }
            if (ten > 0)
            {
                Console.WriteLine("십원" + ten + "개");
            }
            if (one > 0)
            {
                Console.WriteLine(one + "원" );
            }
        }
    }
}
