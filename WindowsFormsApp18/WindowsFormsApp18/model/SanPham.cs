using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18.model
{
    public class SanPham
    {
        public string MaSP {  get; set; }
        public string TenSP { get; set; }
        public double DonGia { get; set; }
        public string XuatXu {  get; set; }
        public string NgaySX { get; set; }

        public DanhMuc IsDanhMuc { get; set; }

        public override string ToString()
        {
            return MaSP + " - " + TenSP + " - " + DonGia + " - " + XuatXu + " - " + NgaySX;
        }
    }
}
