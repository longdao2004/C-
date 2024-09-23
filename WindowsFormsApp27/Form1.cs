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

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strCon);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd= new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM NHACC";
            cmd.Connection = sqlConnection;

            // thuc thi truy van
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maNCC = reader.GetString(0);
                string tenNCC = reader.GetString(1);

                string line = maNCC + "/" + tenNCC;
                lsbNCC.Items.Add(line);
            }
            reader.Close();
        }

        private void lsbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbNCC.SelectedIndex == -1) return;
            
            string line = lsbNCC.SelectedItems.ToString();
            string[] arr = line.Split('/');
            string maNCC = arr[0];

            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strCon);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM DONDH WHERE MaNCC=@maNCC";
            SqlParameter parma = new SqlParameter("@maNCC", SqlDbType.Char);
            parma.Value = maNCC.Trim();
            cmd.Parameters.Add(parma);
            cmd.Connection = sqlConnection;

            //thuc thi truy van
            SqlDataReader reader = cmd.ExecuteReader();
            lsvDonHang.Items.Clear();
            while (reader.Read())
            {
                string soDH = reader.GetString(0);
                DateTime ngayDH = reader.GetDateTime(1);

                ListViewItem lvi = new ListViewItem(soDH);
                lvi.SubItems.Add(ngayDH.ToString());
                lsvDonHang.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
