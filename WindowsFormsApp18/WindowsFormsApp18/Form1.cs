using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp18.model;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        // ds danh muc
        List<DanhMuc> DanhSachDM = new List<DanhMuc>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult kq = MessageBox.Show("Ban co muon thoat k", "Hop Thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // khoi tao du lieu
            KhoiTaoDL();

            HienThiDanhMuc();
        }

        private void HienThiDanhMuc()
        {
            tvDangMuc.Nodes.Clear();

            foreach (DanhMuc itemDM in DanhSachDM)
            {
                TreeNode nodeDM = new TreeNode(itemDM.TenDM);
                nodeDM.Tag = itemDM;
                tvDangMuc.Nodes.Add(nodeDM);
            }
        }

        private void KhoiTaoDL()
        {
            // tao danh muc
            DanhMuc DienThoai = new DanhMuc()
            {
                MaDM = "DT",
                TenDM = "Dien thoai di dong"
            };

            DanhMuc MayTinhBang = new DanhMuc()
            {
                MaDM = "MTB",
                TenDM = "May tinh bang"
            };

            DanhMuc LapTop = new DanhMuc()
            {
                MaDM = "LT",
                TenDM = "LapTop"
            };

            // them danh muc vao listDM
            DanhSachDM.Add(DienThoai);
            DanhSachDM.Add(MayTinhBang);
            DanhSachDM.Add(LapTop);

            // tao ra cac san pham
            SanPham IPhone15 = new SanPham()
            {
                MaSP = "IPhone15",
                TenSP = "IPhone15 pro max",
                DonGia = 15000000,
                XuatXu = "USA",
               //NgaySX = new DateTime(2020, 1, 1)
            };

            SanPham IPhone14 = new SanPham()
            {
                MaSP = "IPhone14",
                TenSP = "IPhone14 pro max",
                DonGia = 10000000,
                XuatXu = "UK",
                //NgaySX = new DateTime(2020, 1, 1)
            };

            SanPham IPhone12 = new SanPham()
            {
                MaSP = "IPhone12",
                TenSP = "IPhone12 pro max",
                DonGia = 7000000,
                XuatXu = "VN",
                //NgaySX = new DateTime(2020, 1, 1)
            };

            // them sp vao listSP trong danh muc
            DienThoai.DanhSachSP.Add(IPhone15);
            IPhone15.IsDanhMuc = DienThoai;

            DienThoai.DanhSachSP.Add(IPhone14);
            IPhone14.IsDanhMuc = DienThoai;

            DienThoai.DanhSachSP.Add(IPhone12);
            IPhone12.IsDanhMuc = DienThoai;

            // hien thi danh muc len comboBox
            cboDanhMuc.Items.Clear();
            cboDanhMuc.Items.Add(DienThoai);
            cboDanhMuc.Items.Add(MayTinhBang);
            cboDanhMuc.Items.Add(LapTop);
        }

        private void tvDangMuc_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node != null)
            {
                DanhMuc danhMuc = e.Node.Tag as DanhMuc;
                lsvSanPham.Items.Clear();

                foreach (SanPham itemSP in danhMuc.DanhSachSP)
                {
                    ListViewItem lvi = new ListViewItem(itemSP.MaSP);
                    lvi.SubItems.Add(itemSP.TenSP);
                    lvi.SubItems.Add(itemSP.DonGia.ToString());
                    lvi.SubItems.Add(itemSP.XuatXu);
                    //lvi.SubItems.Add(itemSP.NgaySX.ToString("dd/MM/yyyy"));
                    lvi.SubItems.Add(itemSP.IsDanhMuc.ToString());

                    lsvSanPham.Items.Add(lvi);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboDanhMuc.SelectedIndex == -1)
            {
                MessageBox.Show("ban chua chon danh muc");
            }

            SanPham sp = new SanPham();
            sp.MaSP = txtMaSP.Text.Trim();
            sp.TenSP = txtTenSp.Text.Trim();
            sp.DonGia = double.Parse(txtDonGia.Text.Trim());
            sp.XuatXu = txtXuatXu.Text.Trim();
            //sp.NgaySX = new DateTime(dtpNgaySX.Value.Year, dtpNgaySX.Value.Month, dtpNgaySX.Value.Day);
            DanhMuc danhMuc = cboDanhMuc.SelectedItem as DanhMuc;
            sp.IsDanhMuc = danhMuc;
            danhMuc.DanhSachSP.Add(sp);

            MessageBox.Show("them thanh cong");
        }

        private void lsvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvSanPham.SelectedItems.Count == 0) { return; }
            ListViewItem lvi = lsvSanPham.SelectedItems[0];
            txtMaSP.Text = lvi.SubItems[0].Text;
            txtTenSp.Text = lvi.SubItems[1].Text;
            txtDonGia.Text = lvi.SubItems[2].Text;
            txtXuatXu.Text = lvi.SubItems[3].Text;

            string[] arr = lvi.SubItems[4].Text.Split('/');
            //dtpNgaySX.Value = new DateTime(int.Parse(arr[2]), int.Parse(arr[1]), int.Parse(arr[0]));
            cboDanhMuc.Text = lvi.SubItems[5].Text;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DanhMuc danhMuc = cboDanhMuc.SelectedItem as DanhMuc;
            string maSP = txtMaSP.Text.Trim();

            foreach (DanhMuc itemDM in DanhSachDM)
            {
                if (danhMuc.MaDM == itemDM.MaDM)
                {
                    foreach (SanPham itemSP in itemDM.DanhSachSP)
                    {
                        if (maSP == itemSP.MaSP)
                        {
                            itemDM.DanhSachSP.Remove(itemSP);
                            return;
                        }
                    }
                }
            }
        }
    }
}
