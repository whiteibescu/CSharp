using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_24Omok
{
    public partial class Form1 : Form
    {
        int margin = 40;
        int rectSize = 30; //눈금 크기
        int rockSize = 28; // 바둑돌 크기
        int dotSize = 10; //화점 크기

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;

            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);

            this.ClientSize = new Size(2 * margin + 18 * rectSize, 2 * margin + 18 * rectSize);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBoard();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DrawBoard()
        {
            g = panel1.CreateGraphics();

            for (int i =0; i < 19; ++i)
            {
                g.DrawLine(pen, new Point(margin + i * rectSize, margin), //세로선 
                    new Point(margin + 1 * rectSize, margin + 18 * rectSize)); //가로선
                g.DrawLine(pen, new Point(margin, margin + i * rectSize), // 가로선
                    new Point(margin + 18 * rectSize, margin + i * rectSize));
            }

            //화점그리기
            for (int x = 3; x <= 15; x += 6)
                for (int y = 3; y <= 15; y += 6)
                {
                    g.FillEllipse(bBrush,
                        margin + rectSize * y - dotSize / 2,
                        margin + rectSize * y - dotSize / 2,
                        dotSize, dotSize);
                }
        }
    }
}
