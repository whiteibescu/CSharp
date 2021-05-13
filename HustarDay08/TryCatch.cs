using System;

namespace HustarDay08
{
    class TryCatch
    {
        static void MyFunc1()
        {
            Console.WriteLine("Error 발생");
            throw new Exception("");
        }


        static void MyFunc()
        {
            Console.WriteLine("MyFunc1() 함수 호출 이전");
            MyFunc1();
            Console.WriteLine("MyFunc1() 함수 호출 이후");
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
                return;
            }
            Console.WriteLine("MyFunc() 함수 호출 이후");
        }
    }
}
