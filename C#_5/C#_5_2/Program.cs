using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Nhập vào giá trị của x và tính y theo công thức sau:
            // Nhap 3 he so
            Console.WriteLine("Nhap vao a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // tinhs delta
            double d = b * b - 4 * a * c;

            //
            if (d < 0)
            {
                Console.WriteLine("vo nghiem");
            }
            else if (d == 0)
            {
                Console.WriteLine("PT co nghiem");
                double x = -b / 2 * a;

                Console.WriteLine("Nghiem la: {0}", x);
            }
            else
            {
                Console.WriteLine("Phuong trinh co 2 nghiem pb");
                double x1 = (-b + Math.Sqrt(d)) / (2 / a);
                double x2 = (-b - Math.Sqrt(d)) / (2 / a);

                Console.WriteLine("Nghiem thu 1 la: {0}", x1);
                Console.WriteLine("Nghiem thu 2 la: {0}", x2);
            }
        }
    }
}