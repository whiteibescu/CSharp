using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay08
{
    class Program
    {
        static void MyFunc1()
        {
            Console.WriteLine("Error 발생");
            //throw new Exception("MyFunc1에서 Error가 발생했습니다.");
        }
        static void MyFunc()
        {
            Console.WriteLine("MyFunc1()함수 호출 이전");
            try
            {
                MyFunc1();
            }
            catch (Exception e)
            {
                Console.WriteLine("MyFunc() ------------->>> Error 발생");
                Console.WriteLine("MyFunc() ------------->>> {0}", e.Message);
                throw new Exception("MyFunc()에서 처리하려 하였으나 처리 못 했습니다. MyFunc1에서 Error가 발생했습니다.");
            }
            finally
            {
                Console.WriteLine("MyFunc함수 finally 호출");
            }
            Console.WriteLine("MyFunc1()함수 호출 이후");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("MyFunc()함수 호출 이전");
            try
            {
                MyFunc();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error 발생");
                Console.WriteLine(e.Message);
                return;
            }
            finally
            {
                Console.WriteLine("Main함수 finally 호출");
            }
            Console.WriteLine("MyFunc()함수 호출 이후");
        }
    }
}