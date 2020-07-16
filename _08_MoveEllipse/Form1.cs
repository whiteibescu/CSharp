using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_MoveEllipse
{
    public partial class Form1 : Form
    {
        const int DIA = 100;
        const int MOVE_VAL = 10;
        int x = 10, y = 10;    //590 //250

        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
/*            this.ClientRectangle.Right, this.ClientRectangle.Top, this.ClientRectangle.Left,
               this.ClientRectangle.Bottom*/
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (!(this.x <= this.ClientRectangle.Left))
                    {
                        this.x -= MOVE_VAL;
                    }
                    break;
                case Keys.Right:
                    if (!(this.x >= this.ClientRectangle.Right - DIA))
                    {
                        this.x += MOVE_VAL;
                    }
                    break;
                case Keys.Up:
                    if (!(this.y <= this.ClientRectangle.Top))
                    {
                        this.y -= MOVE_VAL;
                    }                       
                    break;
                case Keys.Down:
                    if (!(this.y >= this.ClientRectangle.Bottom - DIA))
                    {
                        this.y += MOVE_VAL;
                    }
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
