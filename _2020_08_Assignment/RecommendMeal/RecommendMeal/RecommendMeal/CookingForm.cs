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
                if (ingredient == "양파" && ingredient == "참치" && ingredient == "김치")
                {
                    Console.WriteLine("김치찌개 있습니다");
                    
                }
                else if (ingredient == "계란" && ingredient == "밥")
                {
                    Console.WriteLine("계란밥, 계란말이, 계란찜, 계란국 있습니다");
                }
                
                Console.WriteLine(ingredient);
            }
            
        }
    }
}
