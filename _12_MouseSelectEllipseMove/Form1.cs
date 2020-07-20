using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_MouseSelectEllipseMove
{
    public partial class Form1 : Form
    {
        Image img = null;

        private int x = 50, y = 50;
        private int DIAMETER = 200;
        private bool isSelEllipse = false;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Load += Form1_Load;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp; //이벤트 핸들러 = 메서드
            this.MouseMove += Form1_MouseMove;
            this.Load += Form1_Load1;
        }

        private void Form1_Load1(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;
        }

        int cnt = 0;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Move " + cnt++);

            this.x = e.X -DIAMETER/2;
            this.y = e.Y -DIAMETER / 2;
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Up");

            if (e.Button == MouseButtons.Left)
            {
                this.isSelEllipse = false;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("Mouse Down");

            if (e.Button == MouseButtons.Left)
            {
                int centX = x + DIAMETER / 2;
                int centy = y + DIAMETER / 2;
                //원의 중심좌표와 마우스 클릭 위치를 전달해서
                //원안에 있는지 판단하는 메서드
                if (IsInEllipse(centX, centy, e.X, e.Y) == true)
                {
                    isSelEllipse = true;
                    Invalidate();
                }
            }
        }

        /// <summary>
        /// 원의 중심으로부터 마우스 클릭 위치를 계산하여
        /// 원안에 클릭했는지 원 밖을 클릭했는지 판단
        /// </summary>
        /// <param name="centX">원의 중심 x좌표</param>
        /// <param name="centY">원의 중심 y좌표</param>
        /// <param name="mouseX">마우스 클릭 X좌표</param>
        /// <param name="mouseY">마우스 클릭 Y좌표</param>
        /// <returns>true면 원 내, false면 원 밖</returns>
        private bool IsInEllipse(int centX, int centY, int mouseX, int mouseY)
        {
            if (LengthDistance(centX, centY, mouseX, mouseY) <= DIAMETER / 2)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// 두 점의 거리 계산
        /// </summary>
        /// <param name="x0"></param>
        /// <param name="y0"></param>
        /// <param name="x1"></param>
        /// <param name="x2"></param>
        /// <returns>거리값</returns>
        private double LengthDistance(int x0, int y0, int x1, int y1)
        {
            double result = 0;
            result = Math.Sqrt((double)(x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
            return result;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
