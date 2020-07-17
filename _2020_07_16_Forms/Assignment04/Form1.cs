using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment04
{
    public partial class Form1 : Form
    {
        bool goTimer = false;
        const int DIA = 100;
        const int MOVE_VAL = 10;
        int direction = 1;
        int x = 10, y = 10;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.x += MOVE_VAL;
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:

                    if (goTimer == false)
                    {
                        timer.Start();
                        goTimer = true;
                    }
                    else
                    {
                        timer.Stop();
                        goTimer = false;
                    }
                    break;
                case Keys.Left:
                    direction = 0;
                    break;
                case Keys.Right:
                    direction = 1;
                    break;
                case Keys.Up:
                    direction = 2;
                    break;
                case Keys.Down:
                    direction = 3;
                    break;
            }
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.DarkBlue, 5);
            g.DrawEllipse(myPen, x, y, DIA, DIA);
        }
    }
}
