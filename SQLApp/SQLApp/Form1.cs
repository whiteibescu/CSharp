using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLApp
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        string dbConnInfo = @"Server=localhost;" +
                        @"database=Test_DB;" +
                        @"uid=Test_Login;" +
                        @"pwd=123456";
        public Form1()
        {
            InitializeComponent();

            this.Load += Form1_Load;
            this.FormClosed += Form1_FormClosed;
        }

        void AddResultLogListBox(string result)
        {
            lbResultLog.Items.Add(result);
        }

        void btnEnable(bool conn, bool disconn,
            bool select = false, bool insert = false,
            bool update = false, bool delete = false)
        {
            btnDBConnect.Enabled = conn;
            btnDBDisconnect.Enabled = disconn;
            btnSelectSQL.Enabled = select;
            btnInsertSQL.Enabled = insert;
            btnUpdateSQL.Enabled = update;
            btnDeleteSQL.Enabled = delete;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            btnDBDisconnect_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEnable(true, false);
            tbConnectInfo.Text = dbConnInfo;
        }

        private void btnDBConnect_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(tbConnectInfo.Text);
            try
            {
                conn.Open();
                if(conn.State == ConnectionState.Open)
                {
                    AddResultLogListBox("SQL-Server 연결 성공!");
                    btnEnable(false, true, true, true, true, true);
                }
                else
                {
                    conn = null;
                    AddResultLogListBox("상태 : " + conn.State.ToString());
                }
            }catch(Exception ex)
            {
                conn = null;
                AddResultLogListBox(ex.Message);
            }
        }

        private void btnDBDisconnect_Click(object sender, EventArgs e)
        {
            if(conn != null &&
                (conn.State == ConnectionState.Open ||
                conn.State == ConnectionState.Connecting))
            {
                conn.Close();
                conn = null;
                AddResultLogListBox("SQL-Server 연결 해제");
                btnEnable(true, false);
            }
        }

        private void btnSelectSQL_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertSQL_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateSQL_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteSQL_Click(object sender, EventArgs e)
        {

        }


    }
}
