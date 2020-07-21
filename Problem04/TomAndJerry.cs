using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problem04
{
    public partial class TomAndJerry : Form
    {
        Timer timer = new Timer();
        int catX, catY, mx, my;
        bool mouseClicked = false;
        Image Tom = null;
        Image Jerry = null;
        public TomAndJerry()
        {
            catX = 30; catY = 50;
            BackColor = Color.Black;
            InitializeComponent();
            timer.Interval = 50;
            this.DoubleBuffered = true;
            this.Paint += TomAndJerry_Paint;
            this.MouseDown += TomAndJerry_MouseDown;
            this.MouseUp += TomAndJerry_MouseUp;
            this.MouseMove += TomAndJerry_MouseMove;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (mouseClicked == true)
            {
                int difX = mx - catX, difY = my - catY;
                catX += difX / 10; catY += difY / 10;
                Invalidate();
            }
        }

        private void TomAndJerry_MouseMove(object sender, MouseEventArgs e)
        {
            mx = e.X; my = e.Y;
        }

        private void TomAndJerry_MouseUp(object sender, MouseEventArgs e)
        {
            mouseClicked = false;
            Invalidate();
        }

        private void TomAndJerry_MouseDown(object sender, MouseEventArgs e)
        {
            mouseClicked = true;
            mx = e.X; my = e.Y;
            Invalidate();
        }

        private void TomAndJerry_Paint(object sender, PaintEventArgs e)
        {
            
            Tom = Image.FromFile("../../Tom.jpg");
            Rectangle rc = new Rectangle(catX, catY, 100, 100);

            Jerry = Image.FromFile("../../Jerry.jpg");
            Rectangle rc2 = new Rectangle(mx-15, my-15, 30, 30);
            
            e.Graphics.DrawImage(Tom, rc);
           
            if (mouseClicked == true)
            {
                e.Graphics.DrawImage(Jerry, rc2);
            }

            
        }
    }
}
