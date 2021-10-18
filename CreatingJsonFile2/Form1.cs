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
        ExamMySQL.MySQL mySql = new ExamMySQL.MySQL();        
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
            timer2.Interval = 5000;
            timer2.Start();
            mySql.Show();

        }

        private void Endbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Stop();
            timer2.Stop();            
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            stopWatch.Reset();
            timer2.Stop();
            ProgressList.Items.Clear();
            mySql.Hide();
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
            mySql.SaveCGM_Data();
        }

        public void testing()
        {
            mySql.SaveCGM_Data();
        }
    }
}