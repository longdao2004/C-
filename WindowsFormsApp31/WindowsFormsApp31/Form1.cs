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

namespace WindowsFormsApp31
{
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection myCon = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (myCon == null)
            {
                myCon = new SqlConnection(strCon);
            }
            if (myCon.State == ConnectionState.Closed)
            {
                myCon.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "hienThiDSPhieuNhap";

            cmd.Connection = myCon;
            SqlDataReader reader = cmd.ExecuteReader();
            lsvDs.Items.Clear();
            while (reader.Read())
            {
                string soPhieuNhap = reader.GetString(0);
                DateTime ngayNhap = reader.GetDateTime(1);
                string soDonHang = reader.GetString(2);
                
                ListViewItem lvi = new ListViewItem(soPhieuNhap);
                lvi.SubItems.Add(ngayNhap.ToString("MM/dd/yyyy"));
                lvi.SubItems.Add(soDonHang);

                lsvDs.Items.Add(lvi);

            }
            reader.Close();
        }

        private void lsvDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDs.SelectedItems.Count == 0) { return; }

            ListViewItem lvi = lsvDs.SelectedItems[0];
            string soPN = lvi.SubItems[0].Text.Trim();

            HienThiChiTietPN(soPN);
        }

        private void HienThiChiTietPN(string soPN)
        {
            if (myCon == null)
            {
                myCon = new SqlConnection(strCon);
            }
            if (myCon.State == ConnectionState.Closed)
            {
                myCon.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "HienThiChiTietPN";

            // dinh nghia @
            SqlParameter paramSoPN = new SqlParameter("@soPN", SqlDbType.Char); 
            paramSoPN.Value = soPN;
            cmd.Parameters.Add(paramSoPN);

            cmd.Connection = myCon;

            SqlDataReader reader = cmd.ExecuteReader();
            lsvChiTiet.Items.Clear();
            while (reader.Read())
            {
                string maVtu = reader.GetString(1);
                int slNhap = reader.GetInt32(2);
                decimal dgNhap = reader.GetDecimal(3);

                ListViewItem lvi = new ListViewItem(soPN);
                lvi.SubItems.Add(maVtu);
                lvi.SubItems.Add(slNhap.ToString());
                lvi.SubItems.Add(dgNhap.ToString());

                lsvChiTiet.Items.Add(lvi);
            }
            reader.Close();
        }
    }
}
