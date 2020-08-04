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
    public partial class CookingForm : Form
    {
        List<string> combine = new List<string>();
        Form1 fm1;
        Timer t = new Timer();
        int checknum = 0;
        public CookingForm(Form1 form)
        {
            InitializeComponent();
            fm1 = form;
            t.Interval = 1000;
            t.Tick += T_Tick;
            t.Start();
            this.Load += CookingForm_Load;
        }

        private void CookingForm_Load(object sender, EventArgs e)
        {
            foreach (string ingredient in fm1.listBox1.Items)
            {
                combine.Add(ingredient);
                Console.WriteLine(ingredient);
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            checknum++;
            Console.WriteLine(checknum);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string ingredient in combine)
            {
                Console.WriteLine(ingredient);
            }
        }
    }
}
