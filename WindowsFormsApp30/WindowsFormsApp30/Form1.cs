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
using System.Data.SqlClient;

namespace WindowsFormsApp30
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=QLNH;Integrated Security=True";
        SqlConnection SqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strCon);
            }
            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM NHOMMONAN";

            cmd.Connection = SqlConnection;

            SqlDataReader dr = cmd.ExecuteReader();
            cboNhom.Items.Clear();

            while (dr.Read())
            {
                string maNhom = dr.GetString(0);
                string tenNhom = dr.GetString(1);
                
                string line = maNhom.Trim()+"/"+tenNhom.Trim();

                cboNhom.Items.Add(line);
            }
            dr.Close();
        }

        string idNhomMA = "";

        private void cboNhom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNhom.SelectedIndex == -1) return;

            string line = cboNhom.SelectedItem.ToString();

            string[] arr = line.Split('/');

            idNhomMA = arr[0];

            HienThiMonAnTheoNhom(idNhomMA);
        }

        private void HienThiMonAnTheoNhom(string idNhomMA)
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strCon);
            }
            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM MONAN WHERE IDNhomMA='"+idNhomMA+"'";

            cmd.Connection = SqlConnection;

            SqlDataReader dr = cmd.ExecuteReader();
            lsvDs.Items.Clear();

            while (dr.Read())
            {
                string maMA = dr.GetString(0);
                //string 
                string tenMA = dr.GetString(2);
                string dvTinh = dr.GetString(3);
                float donGia = dr.GetFloat(4);

                ListViewItem lvi = new ListViewItem(maMA);
                lvi.SubItems.Add(idNhomMA);
                lvi.SubItems.Add(tenMA);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(donGia.ToString());

                lsvDs.Items.Add(lvi);
            }
            dr.Close();
        }

        private void btnKo_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bn co muon thoat hay k!", "Hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaKhongPara(idMaMA);
            }
        }

        private void XoaKhongPara(string idMaMA)
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strCon);
            }
            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM MONAN WHERE IDMA='"+idMaMA+"'";

            cmd.Connection = SqlConnection;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xoa du lieu thanh cong");
                HienThiMonAnTheoNhom(idNhomMA);
            }
        }

        string idMaMA = "";

        private void lsvDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDs.SelectedItems.Count == 0) return;

            ListViewItem lvi = lsvDs.SelectedItems[0];

            idMaMA = lvi.SubItems[0].Text.Trim();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bn co muon thoat hay k!", "Hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaCoPara(idMaMA);
            }
        }

        private void XoaCoPara(string idMaMA)
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strCon);
            }
            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM MONAN WHERE IDMA=@maMA";

            SqlParameter parMaMA = new SqlParameter("@maMA", SqlDbType.Char);
            parMaMA.Value = idMaMA;
            cmd.Parameters.Add(parMaMA);

            cmd.Connection = SqlConnection;

            int kq = cmd.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Xoa du lieu thanh cong");
                HienThiMonAnTheoNhom(idNhomMA);
            }
        }
    }
}
