using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class StackandHeap03
    {
        static void Main(string[] args)
        {
            string s1;
            s1 = "홍길동";
            string s2;
            s2 = "김길동";

            s1 = s2;

            Console.WriteLine("s1 = {0}", s1); //김길동
            Console.WriteLine("s2 = {0}", s2); //김길동

            s1 = "박길동";
            Console.WriteLine("s1 = {0}", s1); //박길동
            Console.WriteLine("s2 = {0}", s2); //김길동

            youwant();
        }
        static void youwant()
        {
            string s1;
            string s2;
            s1 = "홍길동";
            s2 = "김길동";
            s1 = s2;

            for (int i = 0; i < 5; ++i)
            {
                Console.WriteLine("s1 : {0}", s1);
            }
        }
    }

}