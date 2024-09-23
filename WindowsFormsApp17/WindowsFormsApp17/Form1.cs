using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // lay thong tin tren cac tabpage
            string hoTen = txtHoten.Text.Trim();
            string gioiTinh = cboGioiTinh.SelectedItem.ToString();
            double diemToan = double.Parse(txtToan.Text.Trim());
            double diemVan = double.Parse(txtVan.Text.Trim());

            // hien thi thong tin
            string s = "Ho ten: " + hoTen + "\n";
            s += "gioi tinh: " + gioiTinh + "\n";
            s += "diem toan: " + diemToan + "\n";
            s += "diem van: " + diemVan + "\n";

            MessageBox.Show(s);
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

            }
            else if (tabControl1.SelectedIndex == 1)
            {

            }

        }
    }
}
