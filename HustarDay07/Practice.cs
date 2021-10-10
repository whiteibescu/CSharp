using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay07
{
    class MyArray<T>
    {
        public MyArray(int iSize = 10)
        {
            m_data = new T[iSize];
        }
        public T this[int iIndex]
        {
            get
            {
                return m_data[iIndex];
            }
            set
            {
                m_data[iIndex] = value;
            }
        }
        public int Size()
        {
            return m_data.Length;
        }
        private T[] m_data;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyArray<int> iArray = new MyArray<int>();
            for (int i = 0; i < iArray.Size(); i++)
            {
                iArray[i] = i;
            }
            for (int i = 0; i < iArray.Size(); i++)
            {
                Console.WriteLine("iArray[{0}] : {1}", i, iArray[i]);
            }

            MyArray<float> fArray = new MyArray<float>();
            for (int i = 0; i < fArray.Size(); i++)
            {
                fArray[i] = i * 1.1f;
            }
            for (int i = 0; i < fArray.Size(); i++)
            {
                Console.WriteLine("fArray[{0}] : {1}", i, fArray[i]);
            }
        }
    }
}