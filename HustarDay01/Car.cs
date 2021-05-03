using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay01
{
    class Cat
    {
/*        int age;   //변수 이름 짓는 방법도 여러가지이다.
        int _age;
        int iAge;
        public int m_iAge; //헝가리언 표기법 팀장들이 좋아하는 변수명
                    //찰스 시머니*/

        public void SetAge(int iAge)
        {
            if (iAge < 0)
            {
                Console.WriteLine("나이는 0 보다 작을 수 없습니다.");
                return;
            }
            this.m_iAge = iAge;
        }

        public int GetAge()
        {
            return m_iAge;
            //int lmsi = this.m_iAge;
            //int imsi = 10;
        }

        private int m_iAge; 
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat(); //힙 메모리로 들어가게 되진다
            Cat c2 = new Cat();
            c1.SetAge(10);
            //SetAge(c1, 10);
            int iAge = c1.GetAge();
            //int iAge = c1.GetAge(c1);
            Console.WriteLine("c1.SetAge : {0}", c1.GetAge());
        }
    }
}