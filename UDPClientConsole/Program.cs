﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;                                               // 네트워크 관련 클래스 사용
using System.Net.Sockets;                                       // Socket 클래스

namespace UDPClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] data = new byte[1024];

            IPAddress ipAddress = IPAddress.Parse("10.89.31.221"); // 접속할 서버의 IP 주소
            IPEndPoint ipep = new IPEndPoint(ipAddress, 3317);  // 접속할 서버를 지정

            // 서버 소켓 생성
            Socket server = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            while (true)
            {
                Console.Write("데이터 입력 >> ");
                string str = Console.ReadLine();
                data = Encoding.Default.GetBytes(str);
                server.SendTo(data, 0, str.Length*2, SocketFlags.None, ipep);                          // 서버에 대이터 전송

                Console.WriteLine("서버에 데이터를 전송하였습니다.");

                if (str == "bye")
                    break;
            }

            server.Close();                                     // 서버 소켓 닫기
        }
    }
}
