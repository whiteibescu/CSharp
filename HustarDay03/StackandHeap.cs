using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "홍길동";
            Console.WriteLine("s1 : {0}", s1);
            MyFunc(s1);
            Console.WriteLine("s1 : {0}", s1);
        }
        static void MyFunc(string s)
        {
            s = "김길동";
            Console.WriteLine("s : {0}", s);
        }
    }
}