using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class myform : Form
    {
        public myform()
        {
            InitializeComponent();
            this.Layout += Myform_Layout;
        }

        private void Myform_Layout(object sender, LayoutEventArgs e)
        {
            this.axWindowsMediaPlayer1.Size = this.ClientSize;

        }
    }
}
