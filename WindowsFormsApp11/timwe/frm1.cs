using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timwe
{
    public partial class frm1 : Form
    {
        int index = 0;
        public frm1()
        {
            InitializeComponent();
        }

        private void frm1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            index++;
            label1.Text = index.ToString();
            if (index == 5)
            {
                timer1.Stop();
                Frm2 frm = new Frm2();
                frm.Show();
            }
        }
    }
}
