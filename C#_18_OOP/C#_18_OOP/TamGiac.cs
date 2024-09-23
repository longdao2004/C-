using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__18_OOP
{
    public class TamGiac
    {
        private double a, b, c;

        public TamGiac()
        {

        }

        /*
        public TamGiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        */
        public void Nhap()
        {
            do
            {
                Console.WriteLine("Nhap vao canh 1: ");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao canh 2: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Nhap vao canh 3: ");
                c = double.Parse(Console.ReadLine());

                if ((a + b <= c) || (a + c <= b) || (b + c <= a))
                {
                    Console.WriteLine("Hay nhap lai sao cho dung dk");
                }
            }
            while ((a+b<=c) || (a+c<=b) || (b+c<=a));
        }

        public double TinhCV()
        {
            return a + b + c;
        }

        public double TinhDT()
        {
            double p = (a+b+c) /2;
            return Math.Sqrt(p*(p-a) * (p-b) * (p-c));
        }


    }
}
