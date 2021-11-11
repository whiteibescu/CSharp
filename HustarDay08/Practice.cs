using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay08
{
    class testing
    {

        static void Main(string[] args)
        {
            List<string> stringlist = new List<string>();
            Console.WriteLine("이름을 한번 적어봅니다");
            stringlist.Add("lets");

            foreach(string word in stringlist)
            {
                Console.WriteLine(word);
            }
        }

    }
}