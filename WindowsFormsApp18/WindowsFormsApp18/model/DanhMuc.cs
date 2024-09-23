using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18.model
{
    public class DanhMuc
    {
        public string MaDM {  set; get; }
        public string TenDM { set; get; }
        public List<SanPham> DanhSachSP { set; get; }

        // ham khoi tao
        public DanhMuc() 
        {
            DanhSachSP = new List<SanPham>();
        }

        public override string ToString()
        {
            return MaDM + " - " + TenDM;
        }
    }
}
