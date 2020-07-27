using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_27_Problem01
{
    public partial class Form1 : Form
    {
        private int x = 50, y = 50;
        private int DIAMETER = 200;
        private bool isSelEllipse = false;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.Load += Form1_Load;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
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
        private double LengthDistance(int x0, int y0, int x1, int y1)
        {
            double result = 0;
            result = Math.Sqrt((double)(x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));
            return result;
        }
        private bool IsInEllipse(int centX, int centY, int mouseX, int mouseY)
        {
            if (LengthDistance(centX, centY, mouseX, mouseY) <= DIAMETER / 2)
            {
                return true;
            }
            return false;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Color.Gold, 10);
            g.DrawEllipse(myPen, x, y, DIAMETER, DIAMETER);

            if (this.isSelEllipse)
            {                
                g.FillEllipse(Brushes.Red, x, y, DIAMETER, DIAMETER);
            }
        }
    }
}
