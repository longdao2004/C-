using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Plain text (*.txt)|*.txt";
            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rtbNoiDung.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                    MessageBox.Show("Luu thanh cong");
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Plain text (*.txt)|*.txt";
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK )
                {
                    Stream stream = openFileDialog1.OpenFile();
                    StreamReader streamReader = new StreamReader(stream);
                    rtbNoiDung.Text = streamReader.ReadToEnd();

                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        rtbNoiDung.Text += line;
                        rtbNoiDung.Text += "\n";
                        line = streamReader.ReadLine();
                    }

                    streamReader.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
