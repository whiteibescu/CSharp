using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grammar
{
    class Cat
    {
        public void DisplayInfo()
        {
            Console.WriteLine("이름 : {0}", NAME);
        }

        public string NAME
        {
            get;
            set;
        }

        public int AGE
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main()
        {
            List<int> intList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < intList.Count; i++)
            {
                Console.WriteLine("{0}", intList[i]);
            }
            intList.ForEach((i) => Console.WriteLine(i));

            var newList = from e in intList
                          where e % 2 == 0
                          select new { NAME = "야옹이" + e };
            foreach (var e in newList)
            {
                Console.WriteLine("NAME : {0}", e.NAME);
            }
        } 
    }
}