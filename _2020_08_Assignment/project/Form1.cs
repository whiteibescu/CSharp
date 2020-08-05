using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 1.클릭하면 다른창 띄우기
 * 2.다른창에 동영상재생하기/인터넷 사이트 주소로 가기
 */


namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            myform myform1 = new myform();
            myform1.ShowDialog(); //showDialog방식은 Modal방식
            
        }
    }
}
