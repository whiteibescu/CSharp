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
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Start();
        }

        private void Endbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
        }

        private void CGM_Jsondata()
        {
            JsonData
        }
    }
}
