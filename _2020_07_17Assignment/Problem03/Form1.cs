using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem03
{
    public partial class Form1 : Form
    {
        int x = 10;
        int y = 10;
        int DIA = 50;
        const int MOVE_VAL = 10;
        int dirX = 1; 
        int dirY = 1;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.DoubleBuffered = true;
            timer.Interval = 1;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.y += MOVE_VAL * dirY;
            if (this.y >= this.ClientRectangle.Bottom - DIA || this.y <= this.ClientRectangle.Top)
            {
                dirY *= -1;
            }

            this.x += MOVE_VAL * dirX;
                if (this.x >= this.ClientRectangle.Right - DIA || this.x <= this.ClientRectangle.Left)
                {
                    dirX *= -1;
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
