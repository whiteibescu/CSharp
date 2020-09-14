using System;

namespace MergeSort
{
    public class program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 9, 8, 5, 4, 2, 3, 7, 6 };

            for (int i = 0; i< array.Length; ++i)
            {
                Console.WriteLine(array[i] + " ");
            }
            Console.WriteLine();

            mergeSort(array, 0, array.Length - 1);
        }
    }

    public static void mergeSort(int[] src, int from, int to)
    {
        int[] temp = new int[src.Length];

        if (from < to)
        {
            int mid = (from + to);
        }

     public static void MergeSort()
            {
    }
}
