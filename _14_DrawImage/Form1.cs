using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_DrawImage
{
    public partial class Form1 : Form
    {
        Image image = null;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;     //깜박임 방지
            this.Load += Form1_Load;        //초기화
            this.Paint += Form1_Paint;      //그리기
            this.Layout += Form1_Layout;    //폼 크기 변경
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image = Image.FromFile("../../장나라.jpg");
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.DrawImage(image, 0, 0);*/
            e.Graphics.DrawImage(image, this.ClientRectangle); //원본 크기 유지
        }
    }
}
