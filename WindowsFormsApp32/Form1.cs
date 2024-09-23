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

namespace WindowsFormsApp32
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection myCon = null;
        SqlDataAdapter myAdapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void HienThiDuLieu()
        {
            if (myCon == null)
            {
                myCon = new SqlConnection(strCon);
            }

            string query = "SELECT * FROM VATTU";
            myAdapter = new SqlDataAdapter(query, myCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(myAdapter);

            ds = new DataSet();

            myAdapter.Fill(ds, "tblVatTu");

            dgvDS.DataSource = ds.Tables["tblVatTu"];
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblVatTu"].NewRow();
            row["MaVtu"] = txtMa.Text.Trim();
            row["TenVtu"] = txtTen.Text.Trim();
            row["DvTinh"] = txtDvTinh.Text.Trim();
            row["PhanTram"] = txtPhanTram.Text.Trim();

            ds.Tables["tblVatTu"].Rows.Add(row);

            int kq = myAdapter.Update(ds.Tables["tblVatTu"]);
            if (kq > 0)
            {
                MessageBox.Show("Them du lieu thanh cong");
            }
            else
            {
                MessageBox.Show("Them du lieu that bai");
            }
        }

        int vt = -1;

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            vt = e.RowIndex;
            if (vt == -1) return;

            DataRow row = ds.Tables["tblVatTu"].Rows[vt];

            txtMa.Text = row["MaVtu"].ToString();
            txtTen.Text = row["TenVtu"].ToString();
            txtDvTinh.Text = row["DvTinh"].ToString();
            txtPhanTram.Text = row["PhanTram"].ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (vt == -1)
            {
                MessageBox.Show("Bn chua chon vat tu");
                return;
            }

            DataRow row = ds.Tables["tblVatTu"].Rows[vt];
            row.BeginEdit();

            row["MaVtu"] = txtMa.Text.Trim();
            row["TenVtu"] = txtTen.Text.Trim();
            row["DvTinh"] = txtDvTinh.Text.Trim();
            row["PhanTram"] = txtPhanTram.Text.Trim();

            row.EndEdit();

            int kq = myAdapter.Update(ds.Tables["tblVatTu"]);
            if (kq > 0)
            {
                MessageBox.Show("Chinh sua du lieu thanh cong");
            }
            else
            {
                MessageBox.Show("Chinh sua du lieu that bai");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bn co muon xoa ko!", "Hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaDuLieu();
            }
        }

        private void XoaDuLieu()
        {
            if (vt == -1)
            {
                MessageBox.Show("Bn chua chon du lieu");
                return;
            }

            DataRow row = ds.Tables["tblVatTu"].Rows[vt];
            row.Delete();

            int kq = myAdapter.Update(ds.Tables["tblVatTu"]);
            if (kq > 0)
            {
                MessageBox.Show("xoa thanh cong");
            }
            else
            {
                MessageBox.Show("xoa that bai");
            }
        }
    }
}
