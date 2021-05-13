using System;

namespace HustarDay08
{
    class TryCatch
    {
        static bool MyFunc1()
        {
            Console.WriteLine("Error 발생");
            return false;
        }


        static bool MyFunc()
        {
            Console.WriteLine("MyFunc1() 함수 호출 이전");
            Console.WriteLine("MyFunc1() 함수 호출 이후");
            return true;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("MyFunc() 함수 호출 이전");
            try
            {
                MyFunc();
            }
            catch (Exception)
            {
                Console.WriteLine("Error 발생");
            }
            Console.WriteLine("MyFunc() 함수 호출 이후");
        }
    }
}
