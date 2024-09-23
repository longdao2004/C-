// Hàm và 1 số thư viện thường dùng
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args) 
        {
            /*
            // Nhap vao 3 canh
            Console.WriteLine("Nhap vao canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh c: ");
            int c = int.Parse(Console.ReadLine());

            // kiem tra tinh hop le cua tam giac
            if (a + b > c && a + c > b && b + c > a)
            {
                int p = (a + b + c) / 2;
                double dt = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
                Console.WriteLine("\n");
                Console.WriteLine("chu vi la: {0}", p * 2);
                Console.WriteLine("Dien tich la: {0}", dt);
            } 
            else
            {
                Console.WriteLine("");
            }
            */

            Console.WriteLine("Nhap vao canh a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao canh c: ");
            int c = int.Parse(Console.ReadLine());
            // kt
            int kt = KiemTraTamGiac(a, b, c);
            // tinh toan
            if (kt == 1);
            {
                int p = (a + b + c) / 2;
                double dt = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("\n");
                Console.WriteLine("chu vi la: {0}", p * 2);
                Console.WriteLine("Dien tich la: {0}", dt);
            } 
        }

        private static int KiemTraTamGiac(int a, int b, int c)
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}