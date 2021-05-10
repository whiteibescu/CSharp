using System;
using System.Collections.Generic;
using System.Text;

namespace HustarDay05
{
    class String
    {
        public void main()
        {


            string s1 = "홍길동";
            string s2 = "박길동";
            string s3 = "이길동";
            string s = s1 + s2 + s3;
            Console.WriteLine("s:{0}", s);

            StringBuilder sBuilder = new StringBuilder();
            sBuilder.Appends(s1);
            sBuilder.Appends(s2);
            sBuilder.Appends(s3);
            string result = sBuilder.ToString();
            Console.WriteLine("result:{0}", result);


        }
    }
}
