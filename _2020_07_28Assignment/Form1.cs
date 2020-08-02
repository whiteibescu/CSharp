using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_28Assignment
{
    class Pos
    {
        // 필드 (this로 접근할 변수)
        int startX, startY, endX, endY;

        // 생성자
        // 파라미터로 받은 변수들을 필드에 매핑하는 함수
        // All Arguments Required Constructor
        public Pos(int x1, int y1, int x2, int y2)
        {
            this.StartX = x1;
            this.StartY = y1;
            this.EndX = x2;
            this.EndY = y2;        }

        public int StartX { get => startX; set => startX = value; }
        public int StartY { get => startY; set => startY = value; }
        public int EndX { get => endX; set => endX = value; }
        public int EndY { get => endY; set => endY = value; }
    }
    public partial class Form1 : Form
    {
        int startX, startY, endX, endY;
        List<Pos> pos = new List<Pos>();
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseDown += Form1_MouseDown;
            this.MouseUp += Form1_MouseUp;
            this.MouseMove += Form1_MouseMove;
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endX = e.X;
                endY = e.Y;
            }
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                endX = e.X;
                endY = e.Y;
                pos.Add(new Pos(startX, startY, endX, endY));
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.startX = e.X;
                this.startY = e.Y;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Gold, 5);
            e.Graphics.DrawLine(pen, startX, startY, endX, endY);

            foreach (Pos p in pos)
            {
                e.Graphics.DrawLine(pen, p.StartX, p.StartY, p.EndX, p.EndY);
            }
        }
    }
}


