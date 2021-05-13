using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//배열 intArray를 출력하는 5가지의 방법
namespace HustarDay08
{
    class Lamda
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine("intArray[{0}] = {1}", i, intArray[i]);
            }

            foreach(var i in intArray)
            {
                Console.WriteLine("{0}", i);
            }
            //Array.ForEach(intArray, MyFunc);
            /*Array.ForEach(intArray, delegate (int i)
            {
                Console.WriteLine("i = {0}", i);
            });*/
            //Array.ForEach(intArray, (i) => Console.WriteLine("i = {0}", i));
            //int Total = intArray.Aggregate(delegate (int i, int j){ return i + j; });
            int Total = intArray.Aggregate((i, j) => i + j);
            Console.WriteLine("Total : {0}", Total);

        }

        static int MyFunc(int i, int j)
        {
            return i + j;
        }
    }
}
