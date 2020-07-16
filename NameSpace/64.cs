using System;
using System.Collections.Generic;
using System.Text;

namespace NameSpace
{
    class CSTest
    {
        static void Main()
        {
            int[] arScore = { 89, 58, 95, 92, 85, 77, 66, 80 };
            Console.Write("정렬전 => ");
            for (int i = 0; i < arScore.Length; i++)
            {
                Console.Write(arScore[i]);
                Console.Write(' ');
            }
            Array.Sort(arScore);
            Array.Reverse(arScore);
            Console.WriteLine();
            Console.Write("정렬 후 => ");
            for (int i = 0; i < arScore.Length; i++)
            {
                Console.Write(arScore[i]);
                Console.Write(' ');
            }
        }
    }
}
