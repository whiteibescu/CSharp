using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay07
{
    class Out
    {
        static int Sum(out float avg)
        {
            int iSum = 0;
            for (int i = 0; i < 10; i++)
            {
                iSum += i;
            }
            avg = iSum / 10.0f;
            return iSum;
        }
        static void Main(string[] args)
        {
            float avg = 0;
            int iSum = Sum(out avg);
            Console.WriteLine("Sum: {0}, AVG : {1}", iSum.avg);
        }
    }
}
