using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _63_NetworkStreamMultiThreadServerForm
{
    public partial class Form1 : Form
    {
        Socket acceptSocket;    // 안내 역할 소켓(연결 처리 소켓)
        IPEndPoint ipep;        // 서버의 주소(ip, port)
        Socket partnerSocket;   // 고객과 통신하는 소켓

        NetworkStream ns;
        StreamWriter sw;

        Thread tAccept;         // 연결담당 스레드
        bool isAccept = true;   // 연결담당 스레드 반복 플래그

        Thread tRecv;           // 수신담당 스레드
        bool isRecv = true;     // 수신담당 스레드 반복 플래그

        /*Main 스레드가 아닌 Sub 스레드에서 윈폼의 컨트롤을 
         직접 접근하면 GUI스레드가 사용중일 때는 예외가 발생하게 된다
         그러므로 사용중일 대는 일단 메서드 호출을 .NET 프레임워크에
         통보를 전달을 해놓으면 .NET이 컨트롤 접근이 안전할 때
         자동으로 호출해준다.
         <요약> 별도 스레드에서 윈폼의 컨트롤을 직접 접근하면
               예외가 발생한다.
         */
        delegate void AddMsgData(string data);
        AddMsgData addMsgData = null;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
