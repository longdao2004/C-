using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp20.model;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        List<SanPham> ds = new List<SanPham>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSP.Text.Trim();
            sp.NgaySX = new DateTime(dtbNgaySX.Value.Year, dtbNgaySX.Value.Month, dtbNgaySX.Value.Day);

            ds.Add(sp);
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            lsvDanhSach.Items.Clear();

            foreach (SanPham itemSP in ds)
            {
                ListViewItem lvi = new ListViewItem(itemSP.MaSP);
                lvi.SubItems.Add(itemSP.TenSP);
                lvi.SubItems.Add(itemSP.NgaySX.ToString("MM/dd/yyyy"));
                lsvDanhSach.Items.Add(lvi); 
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\danhsach.bat";
            bool kt = File.GhiFile(ds, path);
            if (kt == true)
            {
                MessageBox.Show("Ghi file thanh cong");
            }
            else
            {
                MessageBox.Show("Ghi file that bai");
            }

        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath + "\\danhsach.bat";
            if (System.IO.File.Exists(path))
            {
                ds = File.DocFile(path);
                HienThiDanhSach();
            }
            else
            {
                MessageBox.Show("File k ton tai");

            }
        }
    }
}
