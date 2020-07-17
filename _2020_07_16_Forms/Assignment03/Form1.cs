using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment03
{
    public partial class Form1 : Form
    {
        bool isLeft = false;
        bool isTop = false;
        bool isRight = false;
        bool isBottom = false;
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Layout += Form1_Layout;
            this.KeyDown += Form1_KeyDown;
            this.KeyUp += Form1_KeyUp;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {//간지코딩
                case Keys.Left:
                case Keys.Right:
                case Keys.Up:
                case Keys.Down:
                    this.isLeft = false;
                    this.isTop = false;
                    this.isRight = false;
                    this.isBottom = false;
                    break;
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    this.isLeft = true;
                    this.isTop = false;
                    this.isRight = false;
                    this.isBottom = false;
                    break;
                case Keys.Right:
                    this.isLeft = false;
                    this.isTop = false;
                    this.isRight = true;
                    this.isBottom = false;
                    break;
                case Keys.Up:
                    this.isLeft = false;
                    this.isTop = true;
                    this.isRight = false;
                    this.isBottom = false;
                    break;
                case Keys.Down:
                    this.isLeft = false;
                    this.isTop = false;
                    this.isRight = false;
                    this.isBottom = true;
                    break;
            }
            Invalidate();
        }

        private void Form1_Layout(object sender, LayoutEventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Brushes.Black, 1);
            Font f = new Font("Consolas", 16);
            Graphics g = e.Graphics;
            Rectangle rc = this.ClientRectangle;
            rc.Width = 100;
            rc.X = 100;
            rc.Y = 0;
            rc.Height = 100;
            g.DrawRectangle(myPen, rc);

            
            Rectangle rc2 = this.ClientRectangle;
            rc2.Width = 100;
            rc2.X = 0;
            rc2.Y = 100;
            rc2.Height = 100;
            g.DrawRectangle(myPen, rc2);


            Rectangle rc3 = this.ClientRectangle;
            rc3.Width = 100;
            rc3.X = 200;
            rc3.Y = 100;
            rc3.Height = 100;
            g.DrawRectangle(myPen, rc3);


            Rectangle rc4 = this.ClientRectangle;
            rc4.Width = 100;
            rc4.X = 100;
            rc4.Y = 200;
            rc4.Height = 100;
            g.DrawRectangle(myPen, rc4);


            if(this.isTop == true)
            {
                g.FillRectangle(Brushes.Red, rc);
            }
            else if(this.isLeft == true)
            {
                g.FillRectangle(Brushes.Red, rc2);
            }
            else if (this.isRight == true)
            {
                g.FillRectangle(Brushes.Red, rc3);
            }
            else if (this.isBottom == true)
            {
                g.FillRectangle(Brushes.Red, rc4);
            }

            g.DrawString("TOP", f, Brushes.Indigo, 130, 35);
            g.DrawString("LEFT", f, Brushes.Indigo, 25, 135);
            g.DrawString("RIGHT", f, Brushes.Indigo, 215, 135);
            g.DrawString("BOTTOM", f, Brushes.Indigo, 110, 235);
        }
    }
}
