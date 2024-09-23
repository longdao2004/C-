using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // lay ra du lieu trong textBox
            string maSP = txtMaSp.Text.Trim();
            string tenSP = txtTenSp.Text.Trim();
            int soLuong = int.Parse(txtSoLuong.Text.Trim());

            // gan du lieu vao lsvSanPham
            ListViewItem lvi = new ListViewItem(maSP);
            lvi.SubItems.Add(tenSP);
            lvi.SubItems.Add(soLuong.ToString());

            lsvSanPham.Items.Add(lvi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("SP001");
            lvi.SubItems.Add("Sting do");
            lvi.SubItems.Add("10");
            lsvSanPham.Items.Add(lvi);

            lvi = new ListViewItem("SP002");
            lvi.SubItems.Add("Sting vang");
            lvi.SubItems.Add("20");
            lsvSanPham.Items.Add(lvi);
        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lsvSanPham.SelectedItems[0];
                string maSP = lvi.SubItems[0].Text;
                string tenSP = lvi.SubItems[1].Text;
                string soLuong = lvi.SubItems[2].Text;

                txtMaSp.Text = maSP;
                txtTenSp.Text = tenSP;
                txtSoLuong.Text = soLuong;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count > 0)
            {
                string maSP = txtMaSp.Text.Trim();
                string tenSP = txtTenSp.Text.Trim();
                string soLuong = txtSoLuong.Text.Trim();

                ListViewItem lvi = lsvSanPham.SelectedItems[0];
                lvi.SubItems[0].Text = maSP;
                lvi.SubItems[1].Text = tenSP;
                lvi.SubItems[2].Text = soLuong;
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count > 0)
            {
                lsvSanPham.Items.RemoveAt(lsvSanPham.SelectedItems[0].Index);
            }
        }
    }
}
