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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point point = this.Location;
            Form1 f1 = new Form1();
            f1.StartPosition = FormStartPosition.Manual;
            f1.Location = new Point(point.X, point.Y);
            f1.Show();
            this.Hide();

            
        }
    }
}
