using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp19.model;

namespace WindowsFormsApp19
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
            sp.NgaySX = dtbSX.Value;
            ds.Add(sp);

            HienThiDuLieu();
        }

        private void HienThiDuLieu()
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
            try
            {
                string path = Application.StartupPath + "\\danhsach.txt";
                bool kt = File.GhiFile(ds, path);
                if (kt == true)
                {
                    MessageBox.Show("luu thanh cong");
                }
                else
                {
                    MessageBox.Show("Luu that bai");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Application.StartupPath + "\\danhsach.txt";
                if (System.IO.File.Exists(path))
                {
                    ds = File.DocFile(path);
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("File k ton tai");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
