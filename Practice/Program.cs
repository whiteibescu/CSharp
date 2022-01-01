using System;
using System.Collections;

namespace UsingList
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }
        }
    }
    ///Arraylist가 다양한 형식의 객체를 담을 수 있는 이유
    ///public virtual in Add(Object value)
    ///public virtual void Insert(int index, Object value)
}