using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay01
{
    class Cat
    {
        int age;   //변수 이름 짓는 방법도 여러가지이다.
        int _age;
        int iAge;
        public int m_iAge; //헝가리언 표기법 팀장들이 좋아하는 변수명
                    //찰스 시머니
    }
    class Program1
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat(); //힙 메모리로 들어가게 되진다
            c1.m_iAge = 10;
            Console.WriteLine("c1.m_IAge : {0}", c1.m_iAge);
        }
    }
}
