using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp35
{
    public partial class Form2 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=True";
        SqlConnection myCon = null;

        public Form2()
        {
            InitializeComponent();
        }

        bool kt = false;

        private void Form2_Load(object sender, EventArgs e)
        {
            if (myCon == null)
            {
                myCon = new SqlConnection(strCon);
            }

            string sql = "SELECT * FROM NHACC";
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, myCon);

            DataSet ds = new DataSet();
            myDataAdapter.Fill(ds);

            kt = false;
            lsbNCC.DataSource = ds.Tables[0];
            lsbNCC.ValueMember = "MaNCC";
            lsbNCC.DisplayMember = "TenNCC";
            kt = true;
        }

        private void lsbNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbNCC.SelectedIndex == -1) return;

            if (kt == false) return;

            string maNCC = (string)lsbNCC.SelectedValue;
            string sql = "SELECT * FROM DONDH WHERE MaNCC='" + maNCC + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, myCon);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            dgvDonHang.DataSource = ds.Tables[0];
        }
    }
}
