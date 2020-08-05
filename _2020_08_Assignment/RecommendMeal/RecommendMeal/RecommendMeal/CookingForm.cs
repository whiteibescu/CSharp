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
            string rice = "냉동밥", egg = "계란", onion = "양파",
                tofu = "두부", kimchi = "김치", tuna = "참치";

            if (combine.Contains(rice) && combine.Contains(egg))
            {
                Console.WriteLine("계란밥을 추천드립니다.");
            }
            else if (combine.Contains(tofu) && combine.Contains(kimchi))
            {
                Console.WriteLine("두부김치를 추천드립니다.");                
            }
            else if (combine.Contains(tofu) && combine.Contains(tuna))
            {
                Console.WriteLine("두부참치를 추천드립니다.");
            }
            else if (combine.Contains(egg))
            {
                Console.WriteLine("계란말이를 추런드립니다");
                Console.WriteLine("계란찜을 추천드립니다");
            }
            else if (combine.Contains(onion) && combine.Contains(tuna) && combine.Contains(kimchi))
            {
                Console.WriteLine("참치김치볶음밥을 추천드립니다! ");
                Console.WriteLine("참치김치찌개를 추천드립니다! ");
            }



            /*            foreach (string ingredient in combine)
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
                        }*/

        }
    }
}
