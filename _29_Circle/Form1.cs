﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_Circle
{
    public partial class Form1 : Form
    {
        int centX, centY;
        const int RADIUS = 300;

        public Form1()
        {
            InitializeComponent();                                           
            this.Paint += Form1_Paint;
        }

        void DrawWatchNum(Graphics g, int cnt)
        {
            g.FillEllipse(Brushes.Red,
                new RectangleF((float)centX - 15, (float)centY - 15, 30, 30));

            int degree = 360 / cnt;
            for(int i = 0; i < 360; i += degree)
            {
                double x = this.centX + (RADIUS * Math.Cos(i * Math.PI / 180));
                double y = this.centY + (RADIUS * Math.Sin(i * Math.PI / 180));
                g.FillEllipse(Brushes.Gold, 
                    new RectangleF((float)x-10, (float)y-20, 10, 10));
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawWatchNum(e.Graphics, 360);
        }                                                                                                         

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            this.centX = this.Width / 2;
            this.centY = this.Height / 2;                        
        }
    }
}
