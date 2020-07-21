using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem01
{
    public partial class PuppyAndCat : Form
    {
        Image Puppy = null;
        Image Cat = null;
        int mx, my;
        int cycle = 2;
        List<Rectangle> puppies = new List<Rectangle>();
        List<Rectangle> cats = new List<Rectangle>();
        public PuppyAndCat()
        {
            this.BackColor = Color.Black;
            this.DoubleBuffered = true;
            InitializeComponent();
            this.Paint += PuppyAndCat_Paint;
            this.MouseClick += PuppyAndCat_MouseClick;
        }

        private void PuppyAndCat_MouseClick(object sender, MouseEventArgs e)
        {
            mx = e.X; my = e.Y; //마우스 좌표

            if (e.Button == MouseButtons.Left)
            {
                cycle = 0;
            }
            else if (e.Button == MouseButtons.Right)
            {
                cycle = 1;
            }
            Invalidate();
        }

        private void PuppyAndCat_Paint(object sender, PaintEventArgs e)
        {
            Puppy = Image.FromFile("../../Puppy.jpg");
            Rectangle rc = new Rectangle(mx, my, 150, 150);

            Cat = Image.FromFile("../../Cat.jpg");
            Rectangle rc2 = new Rectangle(mx, my, 150, 150);

            if (cycle == 0)
            {
                puppies.Add(rc);
                // e.Graphics.DrawImage(Puppy, rc);
                
            }
            else if (cycle == 1)
            {
                cats.Add(rc2);
            /*    e.Graphics.DrawImage(Cat, rc2);*/                
            }
            cats.ForEach(cat => e.Graphics.DrawImage(Cat, cat));
            puppies.ForEach(puppy => e.Graphics.DrawImage(Puppy, puppy));

        }
    }
}
