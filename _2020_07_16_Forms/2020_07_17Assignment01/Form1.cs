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
        const int DIA = 50;
        const int MOVE_VAL = 20;
        int x = 0, y = 200;
 
        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;

            while (true)
            {
                if (!(this.x >= this.ClientRectangle.Right - DIA))
                {
                    this.x += MOVE_VAL;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Red, 5);
            g.DrawEllipse(myPen, x, y, DIA, DIA);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
