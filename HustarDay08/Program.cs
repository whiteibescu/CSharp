using System;

namespace HustarDay08
{
    class Program
    {
        static bool MyFunc1()
        {
            Console.WriteLine("Error 발생");
            return false;
        }


        static bool MyFunc()
        {
            Console.WriteLine("MyFunc1() 함수 호출 이전");
            bool bResult = MyFunc1();
            if (bResult == false)
            {
                return false;
            }
            Console.WriteLine("MyFunc1() 함수 호출 이후");
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("MyFunc() 함수 호출 이전");
            bool bResult = MyFunc();
            if (bResult == false)
            {
                Console.WriteLine("Error 발생");
                return;
            }
            Console.WriteLine("MyFunc() 함수 호출 이후");
        }
    }
}
