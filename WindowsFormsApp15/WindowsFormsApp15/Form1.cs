using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<SanPhamcs> ds = new List<SanPhamcs>();
            SanPhamcs sp;

            sp = new SanPhamcs() { maSP = "SP001", tenSP = "Banh ngot", soLuong = 10 };
            ds.Add(sp);

            sp = new SanPhamcs() { maSP = "SP002", tenSP = "Nuoc ngot", soLuong = 20 };
            ds.Add(sp);

            sp = new SanPhamcs() { maSP = "SP003", tenSP = "Banh ga", soLuong = 30 };
            ds.Add(sp);

            sp = new SanPhamcs() { maSP = "SP004", tenSP = "My tom", soLuong = 40 };
            ds.Add(sp);

            sp = new SanPhamcs() { maSP = "SP005", tenSP = "Quay ngot", soLuong = 50 };
            ds.Add(sp);

            dgvSanPham.DataSource = ds;

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvSanPham.Rows[e.RowIndex];

            string ma = row.Cells[0].Value.ToString();
            string ten = row.Cells[1].Value.ToString();
            int soLuong = int.Parse(row.Cells[2].Value.ToString());

            MessageBox.Show(ma + " - " + ten + " - " + soLuong);
        }
    }
}
