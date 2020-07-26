using System;

namespace _2020_07_24Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 정수를 입력해주세요");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("두번째 정수를 입력해주세요");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("세번째 정수를 입력해주세요");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((x + y > z && x + z > y && z + y > x) ? ("가능합니다") : ("불가합니다"));

            /*
정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요
삼각형이 가능하려면 두 변의 합이 다른 한 변의 합보다 반드시 커야 합니다. (조건 연산자를 사용하세요)*/
        }
    }
}
