using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_17Assignment01
{
    public partial class Form1 : Form
    {
        const int RAD = 50;
        const int MOVE_VAL = 20;
        int x = 0, y = 200;
        Timer timer = new Timer();
        bool goTimer = false;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;

            if (this.x >= this.ClientRectangle.Right)
            {
                timer.Start();
            }
            else if (this.x < this.ClientRectangle.Right - 100)
            {
                timer.Stop();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.x += MOVE_VAL;
            
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Red, 5);
            g.FillEllipse(Brushes.Red, x, y, RAD, RAD);
            timer.Start();
            /*            if (!(this.x >= this.ClientRectangle.Right - RAD))
                        {
                            this.x += MOVE_VAL;
                        }*/

        }
    }
}
