using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__20_OOP
{
    public class SoPhuc
    {
        private double phanThuc;
        private double phanAo;

        public SoPhuc() 
        {
            phanThuc = 0;
            phanAo = 0;
        }

        public SoPhuc(double phanThuc, double phanAo)
        {
            this.phanThuc = phanThuc;
            this.phanAo = phanAo;
        }

        public void nhapSP()
        {
            Console.WriteLine("Nhap vao phan thuc: ");
            phanThuc = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao phan ao: ");
            phanAo = double.Parse(Console.ReadLine());
        }

        public  void hienThiSP()
        {
            if (phanAo < 0)
            {
                Console.WriteLine(phanThuc + "-" + Math.Abs(phanAo) + "i");
            }
            else
            {
                Console.WriteLine(phanThuc + "+" + phanAo + "i");
            }
        }

        public SoPhuc congSP(SoPhuc sp2)
        {
            double a = phanThuc + sp2.phanThuc;
            double b = phanAo + sp2.phanAo;

            return new SoPhuc(a, b);
        }
    }
}
