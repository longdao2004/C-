using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            // Xoa bo di thong bao loi neu co
            err.SetError(textHoTen, "");
            err.SetError(textTuoi, "");
            err.SetError(dtbNgayDK, "");

            // kiem tra ho ten k dc de trong
            if (textHoTen.Text.Trim() == "")
            {
                err.SetError(textHoTen, "Ho ten ko dc de trong");
                return;
            }

            // kiem tra tuoi lon hon 17
            if (textTuoi.Text.Trim() == "")
            {
                err.SetError(textTuoi, "Tuoi ko dc de trong");
                return;
            }
            else
            {
                int tuoi = Convert.ToInt32(textTuoi.Text.Trim());
                if (tuoi < 18 )
                {
                    err.SetError(textTuoi, "Tuoi ko dc nho hon 18");
                    return;
                }
            } 

            // kiem tra ngay dk khong vao ngay cn
            if (dtbNgayDK.Value.DayOfWeek == DayOfWeek.Sunday)
            {
                err.SetError(dtbNgayDK, "Ko dk thi vao chu nhat");
                return;
            }

            // dung het roi
            MessageBox.Show("Dang ky thanh cong!");
        }
    }
}
