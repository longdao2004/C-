// Bien va kieu du lieu
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3 
{ 
    class Program
    {
        static void Main(String[] args)
        {
            // bien va cach khai bao 
            //int age = 0;
            //const double PI = 3.14;
            //Console.WriteLine("Gia tri cua bien age la: {0}", age);
            //Console.WriteLine("Gia tri cua hang PI la: " + PI);
            //Console.ReadLine();

            // cach ep kieu
            //double x = (double)1 / 2;
            //Console.WriteLine("gia tri: {0}", x);

            // Implicit 
            //var x = 1990;
            //var y = "1/6/2019";
            //var z = 1.4;
            //var t = new DateTime(2019, 1, 1);
            //Console.WriteLine("x co kieu du lie la" + x.GetType());
            //Console.WriteLine("y co kieu du lie la" + y.GetType());
            //Console.WriteLine("z co kieu du lie la" + z.GetType());
            //Console.WriteLine("t co kieu du lie la" + t.GetType());

            // chuyen doi kie khi su dung phuong thuc va lop co ho tro
            Console.WriteLine("Ban hay nhap vao tuoi cua ban: ");
            // Nhap du lieu tu ban phim
            //int tuoi = int.Parse(Console.ReadLine());
            string strTuoi = Console.ReadLine();
            int tuoi = Convert.ToInt32(strTuoi);
            Console.WriteLine("Kieu du lieu cua tuoi la: " + tuoi.GetType());
        }
    }
}