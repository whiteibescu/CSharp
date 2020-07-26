using System;

namespace _2020_07_24Problem09
{
    /* 9.int배열을 10개 생성해라
  사용자로부터 10개의 값을 입력받고
  순서대로 출력하고 
  총합을 구하세요 */
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int sum = 0;

            Console.WriteLine("정수 10개 입력하세요 : ");

            for (int i = 0; i < 10; ++i)
            {
                string input = Console.ReadLine();
                int num = Convert.ToInt32(input);
                arr[i] = num;
                sum += arr[i]; 
            }

            Console.WriteLine("입력된 10개의 정수 =>> ");
            for (int i = 0; i < 10; ++i)
            {
            Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\n총합 : " + sum);
        }
    }
}
