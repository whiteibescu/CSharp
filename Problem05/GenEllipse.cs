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

namespace Problem05
{
    public partial class GenEllipse : Form
    {
        const int DIA = 100;
        int rectX = 0;
        int rectY = 0;
        int width = DIA;
        int height = DIA;

        int newEllipseX = 0; //클릭했을 원 X 좌표
        int newEllipseY = 0; //클릭했을 원 Y 좌표

        List<Rectangle> ellipses = new List<Rectangle>();
        Rectangle[] rectangles = new Rectangle[32];
        

        public GenEllipse()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            this.Paint += GenEllipse_Paint;
            this.MouseClick += GenEllipse_MouseClick;
        }

        private void GenEllipse_MouseClick(object sender, MouseEventArgs e)
        {
            newEllipseX = e.X / 100 * 100; // 사각형에 맞춘다.. 100의 숫자를 뽑아낸다.
            newEllipseY = e.Y / 100 * 100; // 사각형에 맞춘다.. 100의 숫자를 뽑아낸다.
            ellipses.Add(new Rectangle(newEllipseX, newEllipseY, width, height)); //리스트 추가
            rectX = 0; //초기화 = Invalidate();할때마다 새로 그리는데 사각형이 시작하는 좌표or커서 초기화
            rectY = 0; //초기화 = Invalidate();할때마다 새로 그리는데 사각형이 시작하는 좌표or커서 초기화
            Invalidate();
        }

        private void GenEllipse_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Brushes.Black);
            Pen penRed = new Pen(Brushes.Red);
            Pen penBlue = new Pen(Brushes.Blue);

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    rectangles[i].X = rectX;
                    rectangles[i].Y = rectY;
                    rectangles[i].Width = width;
                    rectangles[i].Height = height;
                    g.DrawRectangle(pen, rectangles[i]);
                    rectX += width;
                }
                rectX = 0;
                rectY += height;
            }

            int ellipseCount = 0;

            //ellipses 안에 있는 각 맴버에 대한 별칭 alias =>는 람다식

            ellipses.ForEach(ellipse => 
            {
                if (ellipseCount % 2 == 0) 
                    g.DrawEllipse(penRed, new Rectangle(ellipse.X, ellipse.Y, width, height));
                else
                    g.DrawEllipse(penBlue, new Rectangle(ellipse.X, ellipse.Y, width, height));
                ellipseCount++;
            });
        }
    }
}
