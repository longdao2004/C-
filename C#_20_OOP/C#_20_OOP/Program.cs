using C__20_OOP;
using System;

class Program
{
    static void Main()
    {
        SoPhuc sp1 = new SoPhuc();
        SoPhuc sp2 = new SoPhuc();
        SoPhuc spTong = new SoPhuc();

        Console.WriteLine("Nhap vao sp 1: ");
        sp1.nhapSP();
        Console.WriteLine("Nhap vao sp 2: ");
        sp2.nhapSP();

        spTong = sp1.congSP(sp2);

        Console.WriteLine("\nSo phuc 1 la:");
        sp1.hienThiSP();
        Console.WriteLine("\nSo phuc 2 la:");
        sp2.hienThiSP();
        Console.WriteLine("\nSo phuc tong la:");
        spTong.hienThiSP();
    }
}