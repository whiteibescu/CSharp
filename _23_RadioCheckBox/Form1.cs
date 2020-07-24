using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_radio_checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string selectStr = "";
            if (chkMoney.Checked)
                selectStr += "돈" + "\r\n";
            if (chkHonor.Checked)
                selectStr += "명예" + "\r\n";
            if (chkForce.Checked)
                selectStr += "힘" + "\r\n";
            if (chkPower.Checked)
                selectStr += "권력" + "\r\n";
            if (chkJustice.Checked)
                selectStr += "정의" + "\r\n";

            if (radioDestroyer.Checked)
                selectStr += "카리스마 무소불위 파괴자" + "\r\n";
            else
                selectStr += "평범하고 가정적인 사람" + "\r\n";

            MessageBox.Show(selectStr);
        }
    }
}
