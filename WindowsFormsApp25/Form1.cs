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

namespace WindowsFormsApp25
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKhong_Click(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strCon);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string maVtu = txtMa.Text.Trim();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM VATTU WHERE MaVTU = '" + maVtu + "'";

            cmd.Connection = sqlConnection;

            // thuc thi
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string tenVtu = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                // hien thi len giao dien
                txtTen.Text = tenVtu;
                txtDonVi.Text = dvTinh;
                txtPhanTram.Text = phanTram.ToString();
            }

            // dong dau doc
            reader.Close();
        }

        private void btnCo_Click(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strCon);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            string maVtu = txtMa.Text.Trim();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM VATTU WHERE MaVTU = @MaVTu";

            // dinh nghia @
            SqlParameter param = new SqlParameter("@MaVTu", SqlDbType.Char);
            param.Value = txtMa.Text.Trim();
            cmd.Parameters.Add(param);

            cmd.Connection = sqlConnection;

            // thuc thi
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string tenVtu = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                // hien thi len giao dien
                txtTen.Text = tenVtu;
                txtDonVi.Text = dvTinh;
                txtPhanTram.Text = phanTram.ToString();
            }

            // dong dau doc
            reader.Close();
        }
    }
}
