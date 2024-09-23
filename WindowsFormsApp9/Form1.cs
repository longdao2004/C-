using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            int n = chlDS.CheckedItems.Count;
            if (n > 0 )
            {
                int stt = 0;
                lsvDsDaChon.Items.Clear();
                for ( int i = 0; i < n; i++ )
                {
                    ListViewItem lvi = new ListViewItem((++stt).ToString());
                    lvi.SubItems.Add(chlDS.CheckedItems[i].ToString());

                    // them vao listView
                    lsvDsDaChon.Items.Add(lvi);
                }
            }
        }
    }
}
