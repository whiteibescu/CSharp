using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_27_Problem02
{
    public partial class Form1 : Form
    {
        int mx, my;
        int cycle = 2;
        List<Rectangle> rectangles = new List<Rectangle>();
        Random rnd = new Random();
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseClick += Form1_MouseClick;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            mx = e.X; my = e.Y; //마우스 좌표

            if (e.Button == MouseButtons.Left)
            {
                cycle = 0;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            Pen pen = new Pen(randomColor);
            Rectangle rc = new Rectangle(mx, my, 20, 20);
            
            if (cycle == 0)
            {
                rectangles.Add(rc);
            }

            rectangles.ForEach(rectangle => e.Graphics.DrawRectangle(pen, rectangle));

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
    }
}
