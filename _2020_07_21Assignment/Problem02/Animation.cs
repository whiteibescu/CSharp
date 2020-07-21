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
    public partial class Animation : Form
    {
        public Animation()
        {
            this.BackColor = Color.Black;
            InitializeComponent();
            this.Paint += Animation_Paint;
        }

        private void Animation_Paint(object sender, PaintEventArgs e)
        {
            
            Rectangle cropRect = new Rectangle();
            Bitmap src = Image.FromFile("../../ani.png") as Bitmap;
            Bitmap target = new Bitmap(cropRect.Width, cropRect.Height);

            using (Graphics g = Graphics.FromImage(target))
            {
                g.DrawImage(src, new Rectangle(0, 0, target.Width, target.Height),
                            cropRect,
                            GraphicsUnit.Pixel);
            }
        }
    }
}
