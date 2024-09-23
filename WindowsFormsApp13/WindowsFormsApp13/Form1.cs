using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // lay ngay gio hien tai cua he thong
            DateTime t = DateTime.Now;
            string day = t.Day.ToString();
            string month = t.Month.ToString();
            string year = t.Year.ToString();
            string hour = t.Hour.ToString();
            string minute = t.Minute.ToString();
            string second = t.Second.ToString();

            tssDateTime.Text = day + "/" + month + "/" + year + " - " + hour + " : " + minute + " : " + second;
        }

        private void mnuFileN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("File new");
        }

        private void tsbFileNew_Click(object sender, EventArgs e)
        {
            mnuFileN.PerformClick();
        }
    }
}
