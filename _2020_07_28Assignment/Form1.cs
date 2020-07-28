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
        int startX, startY, endX, endY;
        public Pos(int _startX, int _startY, int _endX, int _endY)
        {
            StartX = startX;
            StartY = startY;
            EndX = endX;
            EndY = endY;
        }

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
                
            }

            Invalidate();
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
            
        }
    }
}
