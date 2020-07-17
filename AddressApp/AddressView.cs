using System;
using System.Collections.Generic;
using System.Text;

namespace AddressApp
{
    class AddressView
    {
        private AddressManager addrMgr = new AddressManager();
        private int selMenu;

        public void MainLoop()
        {
            while (true)
            {
                ShowMenu();
                GetSelMenu();
                DispatchMenu();
            }
        }

        /// <summary>
        /// 화면에 메뉴보여주기
        /// </summary>
        public void ShowMenu()
        {
            Console.WriteLine("------ 주소록 관리 -----");
            Console.WriteLine("1. 주소록 입력");
            Console.WriteLine("2. 주소록 삭제");
            Console.WriteLine("3. 주소록 수정");
            Console.WriteLine("4. 주소록 검색");
            Console.WriteLine("5. 주소록 전체출력");
            Console.WriteLine("6. 어플리케이션 종료");
        }

        /// <summary>
        /// 메뉴 번호 선택 하기
        /// </summary>
        /// <returns>메뉴 번호</returns>
        public void GetSelMenu()
        {
            Console.WriteLine();
            Console.Write("메뉴를 선택하세요 >> ");
            string strNum = Console.ReadLine();
            int num = Int32.Parse(strNum);
            this.selMenu = num;
        }

        /// <summary>
        /// 화면에 주소 정보 출력하기
        /// </summary>
        public static void PrintAddressInfo(Address addr)
        {
            Console.WriteLine(addr.ToString());
        }

        /// <summary>
        /// AddressManager객체에 선택 번호 분기 처리하기
        /// </summary>
        public void DispatchMenu()
        {
            switch (this.selMenu)
            {
                case 1:
                    addrMgr.InsertAddress();
                    break;
                case 2:
                    addrMgr.DeleteAddress();
                    break;
                case 3:
                    addrMgr.UpdateAddress();
                    break;
                case 4:
                    addrMgr.SearchAddress();
                    break;
                case 5:
                    addrMgr.PrintAllAddress();
                    break;
                case 6:
                    addrMgr.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
