using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int onOff = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            picOff.Visible = false;
            picOn.Visible = true;
            btnOnOff.Text = "Off";
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            if (onOff == 1)
            {
                picOff.Visible = true;
                picOn.Visible = false;
                btnOnOff.Text = "On";
                onOff = 0;
            }
            else
            {
                picOff.Visible = false;
                picOn.Visible = true;
                btnOnOff.Text = "Off";
                onOff = 1;
            }
        }
    }
}
