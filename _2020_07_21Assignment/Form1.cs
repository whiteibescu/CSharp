using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_21Assignment
{
    public partial class Form1 : Form
    {
        int X;
        int Y;
        Image img = null;
        TextureBrush tBrush = null;
        public Form1()
        {
            InitializeComponent();
            this.MouseClick += Form1_MouseClick;
            this.Paint += Form1_Paint;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            X = Control.MousePosition.X;
            Y = Control.MousePosition.Y;
            Graphics g = e.Graphics;
            img = Image.FromFile("../../puppy.jpg");
            g.DrawImage(img, X, Y, 10, 10);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                Image image = Image.FromFile("../../puppy.jpg");
                g.DrawImage(img, X, Y, 10, 10);
            }
            else if (e.Button == MouseButtons.Right)
            {
                Image image = Image.FromFile("../../cat.jpg");
                g.DrawImage(img, X, Y, 10, 10);
            }
        }
    }
}
