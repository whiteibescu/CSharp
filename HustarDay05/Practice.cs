using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay05
{
    class CallWorker
    {
        public CallWorker() : this("분신술 사용!!", 5000)
        {
            Console.WriteLine("1번 생성자 호출!!");
            Console.WriteLine("계산대에서 멍때리기");
        }

        public CallWorker(string clean)
        {
            Console.WriteLine("2번 생성자: 매개변수가 1개 ");
            Console.WriteLine("사장왈 " + clean + "\n\n");

        }

        public CallWorker(string clean, int calculation)
        {
            Console.WriteLine("3번 생성자: 매개변수가 2개");
            Console.WriteLine("손님 왈 : 계산 좀 해주세요~" + calculation);
            Console.WriteLine("사장 왈: " + clean + "\n\n");
        }

        public static void Main(string[] args)
        {
            CallWorker call1 = new CallWorker();
            CallWorker call2 = new CallWorker("법사야 청소 좀 해라");
            CallWorker call3 = new CallWorker("법사야 청소좀 해라", 5000);
        }
    }
}
