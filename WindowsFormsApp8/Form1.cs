using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Ban co muon thoat k", "hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            string str = "";
            str = "Thong tin dat hang:\r\n";
            str += "\tHo ten: " + txtHoTen.Text.Trim() + "\r\n";
            str += "\tSo dien thoai: " + txtSDT.Text.Trim() + "\r\n";
            str += "\tMat hang:\r\n";
            str += "\t\t" + lstMatHang.SelectedItem.ToString() + "\r\n";
            str += "\tHinh thuc thanh toan: " + cboThanhToan.SelectedItem.ToString();
            txtThongTin.Text = str;
        }

        private void cboThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboThanhToan.SelectedIndex != -1)
            {
                MessageBox.Show("Ban da chon");
            }
        }
    }
}
