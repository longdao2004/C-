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

namespace WindowsFormsApp28
{
    public partial class Form1 : Form
    {
        string strConn = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection SqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strConn);
            }

            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "SELECT * FROM VATTU";
            sqlCommand.Connection = SqlConnection;

            // thuc thi truy van
            SqlDataReader reader = sqlCommand.ExecuteReader();
            lsvDs.Items.Clear();
            while (reader.Read())
            {
                string maVtu = reader.GetString(0);
                string tenVtu = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                ListViewItem lvi = new ListViewItem(maVtu);
                lvi.SubItems.Add(tenVtu);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(phanTram.ToString());

                lsvDs.Items.Add(lvi);
            }
            reader.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // khong dung parameter
            //KhongDungPar();

            // co dung
            CoDungPar();
        }

        private void KhongDungPar()
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strConn);
            }

            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            // lay du lieu
            string maVtu = txtMa.Text.Trim();
            string tenVtu = txtTen.Text.Trim();
            string dvTinh = txtDv.Text.Trim();
            string phanTram = txtPhanTram.Text.Trim();

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO VATTU VALUES('"+maVtu+"',N'"+tenVtu+"',N'"+dvTinh+"',"+phanTram+")";

            sqlCommand.Connection = SqlConnection;
            int kq = sqlCommand.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Them du lieu thanh cong");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Them du lieu khong thanh cong");
            }
        }

        private void CoDungPar()
        {
            if (SqlConnection == null)
            {
                SqlConnection = new SqlConnection(strConn);
            }

            if (SqlConnection.State == ConnectionState.Closed)
            {
                SqlConnection.Open();
            }

            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.CommandText = "INSERT INTO VATTU VALUES(@maVtu,@tenVtu,@dVTinh,@phanTram)";

            SqlParameter parMaVtu = new SqlParameter("@maVtu", SqlDbType.Char);
            SqlParameter parTenVtu = new SqlParameter("@tenVtu", SqlDbType.NVarChar);
            SqlParameter parDvTinh = new SqlParameter("@dVTinh", SqlDbType.NVarChar);
            SqlParameter parPhanTram = new SqlParameter("@phanTram", SqlDbType.Real);

            parMaVtu.Value = txtMa.Text.Trim();
            parTenVtu.Value = txtTen.Text.Trim();
            parDvTinh.Value = txtDv.Text.Trim();
            parPhanTram.Value = txtPhanTram.Text.Trim();

            sqlCommand.Parameters.Add(parMaVtu);
            sqlCommand.Parameters.Add(parTenVtu);
            sqlCommand.Parameters.Add(parDvTinh);
            sqlCommand.Parameters.Add(parPhanTram);

            sqlCommand.Connection = SqlConnection;

            int kq = sqlCommand.ExecuteNonQuery();
            if (kq > 0)
            {
                MessageBox.Show("Them du lieu thanh cong");
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("Them du lieu khong thanh cong");
            }
        }
    }
}
