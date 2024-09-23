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
using System.Data.SqlTypes;
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp34
{
    public partial class Form1 : Form
    {
        string strCon = Properties.Settings.Default.SettingConn;
        SqlConnection myCon = null;

        //Ham ket noi csdl
        private void OpenConn()
        {
            if (myCon == null)
            {
                myCon = new SqlConnection(strCon);
            }

            if (myCon.State == ConnectionState.Closed)
            {
                myCon.Open();
            }
        }

        // ham dong ket noi
        private void CloseConn()
        {
            if (myCon.State == ConnectionState.Open && myCon != null)
            {
                myCon.Close();
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            try
            {
                OpenConn();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "select * from tblMayBay";
                sqlCmd.Connection = myCon;

                SqlDataReader reader = sqlCmd.ExecuteReader();
                lsvDanhSach.Items.Clear();
                lsvDanhSach.Groups.Clear();

                // Phan loai nhom 1
                ListViewGroup g1 = new ListViewGroup("Thương gia");
                lsvDanhSach.Groups.Add(g1);

                // Phan loai nhom 2
                ListViewGroup g2 = new ListViewGroup("Phổ thông");
                lsvDanhSach.Groups.Add(g2);

                while (reader.Read())
                {
                    int ma = reader.GetInt32(0);
                    string ten = reader.GetString(1);
                    string hangsx = reader.GetString(2);
                    int size = reader.GetInt32(3);
                    int soGhe = reader.GetInt32(4);
                    string phanLoai = reader.GetString(5);

                    ListViewItem lvi = new ListViewItem(ma.ToString());
                    lvi.SubItems.Add(ten);
                    lvi.SubItems.Add(hangsx);
                    lvi.SubItems.Add(size.ToString());
                    lvi.SubItems.Add(soGhe.ToString());
                    lvi.SubItems.Add(phanLoai);

                    lsvDanhSach.Items.Add(lvi);

                    if (string.Compare(phanLoai, "Thương gia", true) == 0)
                    {
                        lvi.Group = g1; // Nhom thuong gia
                    }
                    else
                    {
                        lvi.Group = g2; // Nhom pho thong
                    }

                    lvi.Tag = ma;
                }

                reader.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void HienThiChiTiet(int ma)
        {
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblMayBay WHERE IDMayBay=@ma";

                SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Int);
                parMa.Value = ma;
                cmd.Parameters.Add(parMa);

                cmd.Connection = myCon;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string ten = reader.GetString(1);
                    string hangsx = reader.GetString(2);
                    int size = reader.GetInt32(3);
                    int soGhe = reader.GetInt32(4);
                    string phanLoai = reader.GetString(5);

                    txtMaMB.Text = ma.ToString();
                    txtTenMB.Text = ten;
                    txtKichThuoc.Text = size.ToString();

                    if (hangsx == "Vietnam Airlines") cboHangSX.SelectedIndex = 0;
                    else if (hangsx == "Vietjet Air") cboHangSX.SelectedIndex = 1;
                    else if (hangsx == "Jetstar Pacific Airlines") cboHangSX.SelectedIndex = 2;
                    else cboHangSX.SelectedIndex = 3;

                    if (soGhe == 100) cboSoGhe.SelectedIndex = 0;
                    else if (soGhe == 200) cboSoGhe.SelectedIndex = 1;
                    else cboSoGhe.SelectedIndex = 2;

                    if (phanLoai == "Thương gia") cboPhanLoai.SelectedIndex = 0;
                    else cboPhanLoai.SelectedIndex = 1;
                }
                reader.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show(ex.Message) ; 
            }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvDanhSach.SelectedItems.Count == 0) return;    

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            int ma = (int)lvi.Tag;
            HienThiChiTiet(ma);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMaMB.Text = "";
            txtTenMB.Text = "";
            txtKichThuoc.Text = "";
            cboHangSX.SelectedIndex = 0;
            cboSoGhe.SelectedIndex = 0;
            cboPhanLoai.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Ham kiem tra ma may bay
            bool kq = KiemTraTonTai(txtMaMB.Text.Trim());

            if(kq == false)
            {
                ThemMoiDuLieu();
            }
            else
            {
                CapNhatDuLieu(txtMaMB.Text.Trim());
            }
        }

        private void CapNhatDuLieu(string ma)
        {
            try
            {
                OpenConn();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "update tblMayBay set TenMayBay=@ten, HangSanXuat=@hangsx, KichThuoc=@size, SoGhe=@soGhe, PhanLoai=@phanLoai where IDMayBay=@ma";

                SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Int);
                parMa.Value = ma;
                sqlCmd.Parameters.Add(parMa);

                SqlParameter parTen = new SqlParameter("@ten", SqlDbType.VarChar);
                parTen.Value = txtTenMB.Text.Trim();
                sqlCmd.Parameters.Add(parTen);

                SqlParameter parSize = new SqlParameter("@size", SqlDbType.Int);
                parSize.Value = txtKichThuoc.Text.Trim();
                sqlCmd.Parameters.Add(parSize);

                SqlParameter parHangsx = new SqlParameter("@hangsx", SqlDbType.NVarChar);
                parHangsx.Value = cboHangSX.SelectedItem.ToString();
                sqlCmd.Parameters.Add(parHangsx);

                SqlParameter parSoGhe = new SqlParameter("@soGhe", SqlDbType.Int);
                parHangsx.Value = cboSoGhe.SelectedItem.ToString();
                sqlCmd.Parameters.Add(parSoGhe);

                SqlParameter parPhanLoai = new SqlParameter("@phanLoai", SqlDbType.NVarChar);
                parHangsx.Value = cboPhanLoai.SelectedItem.ToString();
                sqlCmd.Parameters.Add(parPhanLoai);

                sqlCmd.Connection = myCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Cap nhat thanh cong!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Cap nhat that bai!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ThemMoiDuLieu()
        {
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tblMayBay VALUES(@ma,@ten,@hangsx,@size,@soGhe,@phanLoai)";

                SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Int);
                parMa.Value = txtMaMB.Text.Trim();
                cmd.Parameters.Add(parMa);

                SqlParameter parTen = new SqlParameter("@ten", SqlDbType.VarChar);
                parTen.Value = txtTenMB.Text.Trim();
                cmd.Parameters.Add(parTen);

                SqlParameter parSize = new SqlParameter("@size", SqlDbType.Int);
                parSize.Value = txtKichThuoc.Text.Trim();
                cmd.Parameters.Add(parSize);

                SqlParameter parHangsx = new SqlParameter("@hangsx", SqlDbType.NVarChar);
                parHangsx.Value = cboHangSX.SelectedItem.ToString();
                cmd.Parameters.Add(parHangsx);

                SqlParameter parSoGhe = new SqlParameter("@soGhe", SqlDbType.Int);
                parHangsx.Value = cboSoGhe.SelectedItem.ToString();
                cmd.Parameters.Add(parSoGhe);

                SqlParameter parPhanLoai = new SqlParameter("@phanLoai", SqlDbType.NVarChar);
                parHangsx.Value = cboPhanLoai.SelectedItem.ToString();
                cmd.Parameters.Add(parPhanLoai);

                cmd.Connection = myCon;

                int kq = cmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Them thanh cong!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Them that bai!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool KiemTraTonTai(string ma)
        {
            try
            {
                OpenConn();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM tblMayBay WHERE IDMayBay=@ma";

                SqlParameter parMa = new SqlParameter("@ma", SqlDbType.Int);
                parMa.Value = ma;
                cmd.Parameters.Add(parMa);

                cmd.Connection = myCon;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lsvDanhSach.SelectedItems.Count == 0)
            {
                MessageBox.Show("Chua chon du lieu xoa!");
                return;
            }

            ListViewItem lvi = lsvDanhSach.SelectedItems[0];
            int ma = (int)lvi.Tag;

            DialogResult kq = MessageBox.Show("Ban co thuc su muon xoa hay khong", "Hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (kq == DialogResult.Yes)
            {
                XoaDuLieu(ma);
            }
        }

        private void XoaDuLieu(int ma)
        {
            try
            {
                OpenConn();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = CommandType.Text;
                sqlCmd.CommandText = "DELETE FROM tblMayBay WHERE IDMayBay=@ma";

                SqlParameter parMa = new SqlParameter();
                parMa.Value = ma;
                sqlCmd.Parameters.Add(parMa);   

                sqlCmd.Connection = myCon;

                int kq = sqlCmd.ExecuteNonQuery();
                if (kq > 0)
                {
                    MessageBox.Show("Xoa thanh cong!");
                    HienThiDanhSach();
                }
                else
                {
                    MessageBox.Show("Xoa that bai!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInAn_Click(object sender, EventArgs e)
        {
            frmInAn frm = new frmInAn();
            frm.Show();
        }
    }
}
