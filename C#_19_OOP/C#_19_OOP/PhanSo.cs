using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__19_OOP
{
    public class PhanSo
    {
        private int tuSo;
        private int mauSo;

        public PhanSo() 
        { 
            tuSo = 0;
            mauSo = 1;
        }

        public PhanSo(int tuSo, int mauSo)
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
        }

       public void nhapPS()
       {
            int a;
            int b;

            do
            {
                Console.WriteLine("Nhap vao tu so: ");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Nhap vao mau so: ");
                b = int.Parse(Console.ReadLine());

                // kiem tra dk
                if (b == 0)
                {
                   Console.WriteLine("Hay nhap mau khac 0!");
                }
                else
                {
                    tuSo = a;
                    mauSo = b;
                }
            }
            while (b == 0);
       }

        public void hienThiPS()
        {
            if (tuSo * mauSo < 0)
            {
                Console.WriteLine("-" + Math.Abs(tuSo) + "/" + Math.Abs(mauSo));
            }
            else
            {
                Console.WriteLine(Math.Abs(tuSo) + "/" + Math.Abs(mauSo));
            }
        }

        private int timUSCLN(int a, int b)
        {
            int r = a % b;

            while (r != 0)
            {
                a = b;
                b = r;
                r = a % b;
            }
            return b;
        }

        public void rutGonPS()
        {
            int x = timUSCLN(tuSo, mauSo);
            tuSo /= x;
            mauSo /= x;
        }

        public PhanSo tinhTongPS(PhanSo ps2)
        {
            int tu = tuSo * ps2.mauSo + ps2.tuSo *mauSo;
            int mau = mauSo * ps2.mauSo;

            return new PhanSo(tu, mau);
        }
    } 
}
