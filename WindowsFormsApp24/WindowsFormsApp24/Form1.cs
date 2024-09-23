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

namespace WindowsFormsApp24
{
    public partial class Form1 : Form
    {
        // chuoi ket noi
        string sqlCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(sqlCon);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            // doi tuong thuc thi truy van
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT COUNT(*) FROM VATTU";

            // gui truy van vao ket noi
            sqlCmd.Connection = sqlConnection;

            // nhan ket qua
            int soLuong = (int)sqlCmd.ExecuteScalar();

            MessageBox.Show("So luong vat tu: " + soLuong);
        }
    }
}
