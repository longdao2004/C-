using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp23
{
    

    public partial class Form1 : Form
    {
        // tao 2 bien cuc bo
        string strConn = @"Data Source=long;Initial Catalog=test;Integrated Security=True";
        // doi tuong ket noi
        SqlConnection sqlConn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMo_Click(object sender, EventArgs e)
        {
            try
            {
                if (sqlConn == null)
                {
                    sqlConn = new SqlConnection(strConn); // rong thi tao moi
                }
                
                // mo ket noi
                if (sqlConn.State == ConnectionState.Closed)
                {
                    sqlConn.Open(); // dong thi mo
                    MessageBox.Show("Ket noi thanh cong");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (sqlConn != null && sqlConn.State == ConnectionState.Open)
            {
                sqlConn.Close();
                MessageBox.Show("Dong ket noi thanh cong");
            }
            else
            {
                MessageBox.Show("Chua tao ket noi");
            }
        }
    }
}
