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

namespace WindowsFormsApp35_3
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True;Encrypt=True";
        SqlConnection sqlCon = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        BindingSource bs = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
            {
                sqlCon = new SqlConnection(strCon);
            }

            string sql = "select * from VATTU";
            adapter = new SqlDataAdapter(sql, sqlCon);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "tblVatTu");

            bs = new BindingSource(ds, "tblVatTu");
            txtMa.DataBindings.Add("Text", bs, "MaVTu");
            txtTen.DataBindings.Add("Text", bs, "TenVTu");
            txtDVTinh.DataBindings.Add("Text", bs, "DvTinh");
            txtPhanTram.DataBindings.Add("Text", bs, "PhanTram");

            lblTrang.Text = "Trang: " + (bs.Position + 1) + " of " + bs.Count;
        }

        private void btnDauTien_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
            lblTrang.Text = "Trang: " + (bs.Position + 1) + " of " + bs.Count;
        }

        private void btnLuiMot_Click(object sender, EventArgs e)
        {
            if (bs.Position > 0)
                bs.Position--;

            lblTrang.Text = "Trang: " + (bs.Position + 1) + " of " + bs.Count;
        }

        private void btnCuoiCung_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
            lblTrang.Text = "Trang: " + (bs.Position + 1) + " of " + bs.Count;
        }

        private void btnTienMot_Click(object sender, EventArgs e)
        {
            if (bs.Position < bs.Count - 1)
                bs.Position++;

            lblTrang.Text = "Trang: " + (bs.Position + 1) + " of " + bs.Count;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bs.AddNew();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            bs.EndEdit();

            int kt = adapter.Update(ds.Tables["tblVatTu"]);
            if (kt > 0)
            {
                MessageBox.Show("Luu thanh cong!");
            }
            else
            {
                MessageBox.Show("Luu that bai!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            bs.RemoveCurrent();

            int kt = adapter.Update(ds.Tables["tblVatTu"]);
            if (kt > 0)
            {
                MessageBox.Show("Xoa thanh cong!");
            }
            else
            {
                MessageBox.Show("Xoa that bai!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kt = MessageBox.Show("Ban co thuc thoat phan mem khong?", "Hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kt == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
