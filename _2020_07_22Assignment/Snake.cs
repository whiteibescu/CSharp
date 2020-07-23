using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_07_22Assignment
{

    public partial class Snake : Form
    {
        const int size = 20;
        const int MOVE = 10;
        int WIDTH = size;
        int HEIGHT = size;
        int ax, ay;
        int x, y;
        Random r = new Random();

        bool isStart = false;
        Timer timer = new Timer();
        List<Rectangle> rectangles = new List<Rectangle>();
        public Snake()
        {
            for (int i = 0; i < 10; i++)
            {
                ax = r.Next(200);
                ay = r.Next(200);
                rectangles.Add(new Rectangle(ax, ay, WIDTH, HEIGHT));
            }
            InitializeComponent();
            this.Paint += Snake_Paint;
            this.KeyDown += Snake_KeyDown;
            timer.Interval = 100;
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            isStart = true;
            switch (e.KeyCode)
            {
                case Keys.Left:
                    x -= MOVE;
                    break;
                case Keys.Right:
                    x += MOVE;
                    break;
                case Keys.Up:
                    y -= MOVE;
                    break;
                case Keys.Down:
                    y += MOVE;
                    break;

            }
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen myPen = new Pen(Brushes.Yellow, 7);
            g.DrawRectangle(myPen, x, y, WIDTH, HEIGHT);
            g.FillRectangle(Brushes.Blue, x, y, WIDTH, HEIGHT);

            /*for (int i = 0; i < 10; i++)
            {
                ax = r.Next(200);
                ay = r.Next(200);
                rectangles.Add(new Rectangle(ax, ay, WIDTH, HEIGHT));
            }*/

            rectangles.ForEach(rectangle =>
            {
                /*g.FillRectangle(Brushes.Red, ax, ay, WIDTH, HEIGHT);*/
                g.FillRectangle(Brushes.Red, rectangle);

            });
        }
    }
}
