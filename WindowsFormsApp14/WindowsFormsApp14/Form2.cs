using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("SP001");
            lvi.SubItems.Add("Sting do");
            lvi.SubItems.Add("10");

            lsvSanPham.Items.Add(lvi);

            lvi = new ListViewItem("SP002");
            lvi.SubItems.Add("Sting vang");
            lvi.SubItems.Add(15.ToString());

            lsvSanPham.Items.Add(lvi);

            lvi = new ListViewItem("SP003");
            lvi.SubItems.Add("Bo huc");
            lvi.SubItems.Add(20.ToString());

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

                MessageBox.Show(maSP + " - " + tenSP + " - " + soLuong);
            }
        }

        private void lsvSanPham_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != -1)
            {
                ColumnHeader col = lsvSanPham.Columns[e.Column];

                MessageBox.Show(col.Text);
            }
        }
    }
}
