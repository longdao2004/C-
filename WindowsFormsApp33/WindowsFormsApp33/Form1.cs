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
using Microsoft.Reporting.WinForms;

namespace WindowsFormsApp33
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

            string sql = "SELECT * FROM VATTU";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, myCon);
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds, "VatTu");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp33.ReportVatTu.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["VatTu"];

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
