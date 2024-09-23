using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp34
{
    public partial class frmInAn : Form
    {
        string strCon = Properties.Settings.Default.SettingConn;
        SqlConnection myCon = null;

        public frmInAn()
        {
            InitializeComponent();
        }

        private void frmInAn_Load(object sender, EventArgs e)
        {
            if (myCon == null)
            {
                myCon = new SqlConnection(strCon);
            }

            string sql = "select * from tblMayBay";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, myCon);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "tblMayBay");

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Bai54.ReportMayBay.rdlc";
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = ds.Tables["tblMayBay"];

            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
