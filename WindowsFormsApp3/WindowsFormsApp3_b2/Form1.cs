using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult ret = MessageBox.Show("ban co muon thoat khong", "Hop thoai", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "timoday.edu.vn";
        }
    }
}
