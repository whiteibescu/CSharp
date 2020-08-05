using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _001
{
    public partial class Form2 : _001.Form1
    {
        Image image = null;
        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Load += Form2_Load;
            this.Paint += Form2_Paint;
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(image, this.ClientRectangle,//폼에서의 이미지 출력 원점
                new Rectangle(130, 62, 1000 - 132, 850 - 62), GraphicsUnit.Pixel);// 이미지의 추출 범위
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            image = Image.FromFile("../../train.jpg");
        }
    }
}
