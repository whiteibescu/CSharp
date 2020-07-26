using System;

namespace _2020_07_24Problem08
{

    /*8.int배열을 10개 생성해라.
     int배열에 3의 배수를 차례대로 저장해라.
     그리고 거꾸로 출력해라.*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int num = 0;


            for (int i = 0; i < 10; ++i)
            {
                num = (3 * i) + 3;
                arr[i] = num;
            }

            for (int i = 9; i > 0; --i)
            {
                Console.WriteLine("3의 배수 출력 = > " + arr[i]);
            }
        }
    }
}
