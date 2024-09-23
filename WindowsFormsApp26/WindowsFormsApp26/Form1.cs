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

namespace WindowsFormsApp26
{
    

    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LONG\LONG9NGON;Initial Catalog=Quanlybanhang;Integrated Security=True";
        SqlConnection sqlConnection = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            if (sqlConnection == null)
            {
                sqlConnection = new SqlConnection(strCon);
            }

            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();
            }

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM VATTU";
            cmd.Connection = sqlConnection;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maVtu = reader.GetString(0);
                string tenVtu = reader.GetString(1);
                string dvTinh = reader.GetString(2);
                float phanTram = reader.GetFloat(3);

                ListViewItem lvi = new ListViewItem(maVtu);
                lvi.SubItems.Add(tenVtu);
                lvi.SubItems.Add(dvTinh);
                lvi.SubItems.Add(phanTram.ToString());

                lsvThongTin.Items.Add(lvi); 
            }

            reader.Close();
        }
    }
}
