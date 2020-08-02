using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_30Assignment
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.MouseDoubleClick += Form1_MouseDoubleClick;

        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
            if(e.Button == MouseButtons.Left)
            {
                 
            }
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Brushes.Yellow, 3);
            e.Graphics.DrawLine(pen, 0, 140, 800, 140);
            e.Graphics.DrawLine(pen, 0, 300, 800, 300);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
