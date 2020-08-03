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
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();

        }

        private void btnModalForm_Click(object sender, EventArgs e)
        {
            CookingForm cookingForm = new CookingForm();
            cookingForm.ShowDialog();
        }

        private void btnEggs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("계란");
        }

        private void btnTuna_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("참치");
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("양파");
        }

        private void btnKimchi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("김치");
        }

        private void btnTofu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("두부");
        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("냉동밥");
        }

        private void btnLeftMove_Click(object sender, EventArgs e)
        {
            /*listBox1.SelectedIndex*/
            
            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch(ArgumentException)
            {
                MessageBox.Show("제거할 재료를 선택하세요!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
