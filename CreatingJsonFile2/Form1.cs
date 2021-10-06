using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CreatingJsonFile2
{
    public partial class Form1 : Form
    {
        Stopwatch stopWatch;
        object JsonData = new {
            Time = "",
            Bosul = "",
            Basal = ""
        };

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            WatchValue.Text = string.Format("{0:hh\\:mm\\:ss\\.ff}", stopWatch.Elapsed);
/*            string currentSeconds = string.Format("{0}", stopWatch.Elapsed.Seconds);
            int checkSeconds = Convert.ToInt32(currentSeconds);
            if (checkSeconds % 5 == 0 && checkSeconds != 0)
            {
                if (ProgressList.Items.Contains(cgmDataText))
                {

                }
                else
                {
                    ProgressList.Items.Add(cgmDataText);
                }
            }*/
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
            timer2.Interval = 5000;
            timer2.Start();
        }

        private void Endbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            timer2.Stop();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            ProgressList.Items.Clear();
        }

        private void CGM_Jsondata()
        {
            
        }

        private void ProgressList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            ProgressList.Items.Add("CGM data has been transferred.");
        }
    }
}