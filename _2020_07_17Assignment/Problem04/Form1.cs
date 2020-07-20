using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem04
{
    public partial class Form1 : Form
    {
        int x = 10;
        int y = 10;
        int a = 10;
        int b = 300;
        int DIA = 50;
        const int MOVE_VAL = 10;
        int dirX = 1; // 밑으로
        int dirY = 1;
        Timer timer = new Timer();
        double score = 0;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.DoubleBuffered = true;
            this.KeyDown += Form1_KeyDown;
            timer.Interval = 30;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Left:                  
                    this.a -= MOVE_VAL;
                break; 
                case Keys.Right:
                    this.a += MOVE_VAL;
                break;
                case Keys.Up:
                    this.b -= MOVE_VAL;
                break;
                case Keys.Down:
                    this.b += MOVE_VAL;               
                break;
            }
            Invalidate();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.y += MOVE_VAL * dirY;
            if (this.y >= this.ClientRectangle.Bottom - DIA || this.y <= this.ClientRectangle.Top)
            {
                dirY *= -1;
                if (this.y >= this.ClientRectangle.Bottom - DIA)
                {
                    score -= 10;
                }
            }

            this.x += MOVE_VAL * dirX;
            if (this.x >= this.ClientRectangle.Right - DIA || this.x <= this.ClientRectangle.Left)
            {
                dirX *= -1;
            }

            if(this.y + DIA >= this.b && this.y <= this.b + 10 && this.x >= this.a && this.x <=this.a + 100)
                //if(this.y + DIA >= Rectangle.bottom && this.y <= Rectangle.bottom + 10 && this.x >= this.Top && this.x <= this.Top + 100
            {
                dirY *= -1;
                score += 1;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, x, y, DIA, DIA);
            Font f = new Font("Consolas", 20);
            g.DrawString("" + score, f, Brushes.White, this.ClientRectangle.Right - 100, this.ClientRectangle.Top + 20);
                                   
            Rectangle rc = new Rectangle(a, b, 150, 30);
            g.FillRectangle(Brushes.Gold, rc);
        }
    }
}
