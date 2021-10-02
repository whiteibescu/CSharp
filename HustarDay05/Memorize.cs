using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HustarDay08
{
    class Member
    {
        public string NAME;
        public string ADDR;
        public string TELNO;
        public int MEMGUBUN;
    }
    class Memgubun
    {
        public int MEMGUBUN;
        public string MEMGUBUNNAME;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Member> MemList = new List<Member>()
            {
                new Member() {NAME = "홍길동", ADDR = "서울",TELNO = "123-1234" ,MEMGUBUN = 1},
                new Member() {NAME = "김길동", ADDR = "부산",TELNO = "234-1234" ,MEMGUBUN = 2},
                new Member() {NAME = "이길동", ADDR = "대구",TELNO = "345-1234" ,MEMGUBUN = 3},
                new Member() {NAME = "박길동", ADDR = "포항",TELNO = "456-1234" ,MEMGUBUN = 1},
                new Member() {NAME = "최길동", ADDR = "광주",TELNO = "567-1234" ,MEMGUBUN = 2}
            };
            List<Memgubun> MemGubunList = new List<Memgubun>()
            {
                new Memgubun() {MEMGUBUN = 1, MEMGUBUNNAME="정회원"},
                new Memgubun() {MEMGUBUN = 2, MEMGUBUNNAME="일반회원"},
                new Memgubun() {MEMGUBUN = 3, MEMGUBUNNAME="임신회원"},
            };

            var result = from m in MemList
                         select new { NAME = m.NAME, ADDR = m.ADDR };
            foreach (var r in result)
            {
                Console.WriteLine("NAME : {0}", r.NAME);
                Console.WriteLine("ADDR : {0}", r.ADDR);
                Console.WriteLine("TELNO : {0}", r.TELNO);
            }
        }
    }
}