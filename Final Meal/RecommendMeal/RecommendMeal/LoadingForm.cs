using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RecommendMeal
{
    public partial class LoadingForm : Form
    {
        Image image = null;
        Timer FormTimer = new Timer();
        Timer progressbarTimer = new Timer();

        int i = 0;
        int num = 20;
        int x = 300, y = 100;
        public LoadingForm()
        {
            InitializeComponent();
            this.Paint += Form1_Paint;
            this.Load += Form1_Load;
            FormTimer.Interval = 1000;
            FormTimer.Tick += Timer_Tick;
            FormTimer.Start();
            progressbarTimer.Interval = 1000;
            progressbarTimer.Tick += Progressbar_Tick;
            progressbarTimer.Start();
            //this.DoubleBuffered = true;
        }

        private void Progressbar_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += num;
            if (progressBar1.Value == 100)
            {
                progressbarTimer.Stop();
               
            }



        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i == 6) { this.Close(); }
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            image = Image.FromFile("../../Cooking.gif");
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
