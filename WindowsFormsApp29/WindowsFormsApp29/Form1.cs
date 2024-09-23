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

namespace WindowsFormsApp29
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=QLNH;Integrated Security=True";
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

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM NHOMMONAN";

            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();
            cboNhomMonAn.Items.Clear();
            while (reader.Read())
            {
                string idNhom = reader.GetString(0);
                string tenNhom = reader.GetString(1);
                string line = idNhom.Trim() + "/" + tenNhom;
                cboNhomMonAn.Items.Add(line);
            }
            reader.Close();
        }

        private void cboNhomMonAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhomMonAn.SelectedIndex == -1) return;

            string line = cboNhomMonAn.SelectedIndex.ToString();
            string[] arr = line.Split('/');
            string maNhom = arr[0];

            // Hien thi thong tin mon an theo nhom
            HienThiThongTinMA(maNhom);
        }

        private void HienThiThongTinMA(string maNhom)
        {
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
            cmd.CommandText = "SELECT * FROM MONAN WHERE IDNhomMA = '"+ maNhom +"'";
            
            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();

            lsvDS.Items.Clear();

            while (reader.Read())
            {
                string idMA = reader.GetString(0);
                string idNhomMA = reader.GetString(1);
                string tenMA = reader.GetString(2);
                string dvTinh = reader.GetString(3);
                float gia = reader.GetFloat(4);

                ListViewItem lvi = new ListViewItem(idMA);
                lvi.SubItems.Add(idNhomMA);
                lvi.SubItems.Add(tenMA);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(gia.ToString());

                lsvDS.Items.Add(lvi);
            }

            reader.Close();
        }
    }
}
