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
            // Nhap 
            Console.WriteLine("Nhap vao x: ");
            double x = double.Parse(Console.ReadLine());
            double y;
            if (x >= 5)
            {
                 y = Math.Pow(5, x) + Math.Sqrt(x * x + 4);
            }
            else
            {
                 y = Math.Abs(x) + Math.Log(x*x+4)/Math.Log(5);
            }

            Console.WriteLine("Gia tri cua y la: {0}", y);
        }
    }
}