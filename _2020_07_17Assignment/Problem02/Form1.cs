using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem02
{
    public partial class Form1 : Form
    {
        int x = 400;
        int y = 10;
        int DIA = 50;
        const int MOVE_VAL = 10;
        int direction = 1; // 밑으로
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Paint += Form1_Paint;
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (this.direction == 1)
            {
                if (this.y >= this.ClientRectangle.Bottom - DIA)
                {
                    direction = -1;
                }
                this.y += MOVE_VAL;
            }
            else
            {
                if (this.y <= this.ClientRectangle.Top)
                {
                    direction = 1; 
                }
                this.y -= MOVE_VAL;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.Red, x, y, DIA, DIA);
        }
    }
}
