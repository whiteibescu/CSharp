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
/*            CookingForm cookingForm = new CookingForm();

            cookingForm.ShowDialog();*/


           /* CookingForm cookingForm = new CookingForm(this);
            cookingForm.Show();*/
            LoadingForm loadingForm = new LoadingForm();
            loadingForm.Show();
             

        }

        private void btnEggs_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("계란");
            btnEggs.Hide();
        }

        private void btnTuna_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("참치");
            btnTuna.Hide();
        }

        private void btnOnion_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("양파");
            btnOnion.Hide();
        }

        private void btnKimchi_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("김치");
            btnKimchi.Hide();
        }

        private void btnTofu_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("두부");
            btnTofu.Hide();
        }

        private void btnRice_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("냉동밥");
            btnRice.Hide();
        }

        private void btnLeftMove_Click(object sender, EventArgs e)
        {
            /*listBox1.SelectedIndex*/

            try
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("제거할 재료를 선택하세요!");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            StartingForm sf = new StartingForm();
            sf.Show();
            this.Hide();
        }
    }
}
