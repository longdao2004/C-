using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Lay ra so trong textBox
            int x = Convert.ToInt32(txtInput.Text.Trim());

            // them x vao listbox
            lstDanhSach.Items.Add(x);

            // xoa di pt da nhap
            txtInput.Clear();
        }

        private void btnTongDS_Click(object sender, EventArgs e)
        {
            int s = 0;
            int n = lstDanhSach.Items.Count;
            for (int i = 0; i < n; i++)
            {
                int x = (int)lstDanhSach.Items[i];
                s += x;
            }
            MessageBox.Show("Tong cac phan tu tren ds la: " + s);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.RemoveAt(0);
            lstDanhSach.Items.RemoveAt(lstDanhSach.Items.Count - 1);
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            while (lstDanhSach.SelectedIndices.Count > 0)
            {
                lstDanhSach.Items.RemoveAt(lstDanhSach.SelectedIndices[0]);
            }
        }

        private void btnTangHai_Click(object sender, EventArgs e)
        {
            int n = lstDanhSach.Items.Count;
            for (int i = 0;i < n;i++)
            {
                int x = (int)lstDanhSach.Items[i];
                x += 2;
                lstDanhSach.Items[i] = x;
            }
        }

        private void btnBinhPhuong_Click(object sender, EventArgs e)
        {
            int n = lstDanhSach.Items.Count;
            for (int i = 0; i < n;i++)
            {
                int x = (int)lstDanhSach.Items[i];
                x = x * x;
                lstDanhSach.Items[i] = x;
            }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            // xoa bo di su lua chon trc do
            lstDanhSach.SelectedIndex = -1;

            int n = lstDanhSach.Items.Count;
            for (int i = 0; i <n;i++)
            {
                int x = (int)lstDanhSach.Items[i];
                if (x % 2 == 0)
                {
                    lstDanhSach.SelectedIndex = i;
                }
            }
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            lstDanhSach.SelectedIndex = -1;
            int n = lstDanhSach.Items.Count;
            for (int i = 0;i <n;i++)
            {
                int x = (int)lstDanhSach.Items[i];
                if (x % 2 != 0)
                {
                    lstDanhSach.SelectedIndex=i;
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Ban co muon thoat k", "hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
