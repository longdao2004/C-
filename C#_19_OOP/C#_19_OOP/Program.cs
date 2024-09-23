using C__19_OOP;
using System;

class Program
{
    static void Main()
    {
        PhanSo phanSo1 = new PhanSo();
        PhanSo phanSo2 = new PhanSo();
        PhanSo psTong = new PhanSo();

        Console.WriteLine("Nhap vao ps1: ");
        phanSo1.nhapPS();
        Console.WriteLine("Nhap vao ps2: ");
        phanSo2.nhapPS();

        psTong = phanSo1.tinhTongPS(phanSo2);

        Console.WriteLine("Phan so 1 o dang chua rut gon la:");
        phanSo1.hienThiPS();
        Console.WriteLine("Phan so 2 o dang chua rut gon la:");
        phanSo2.hienThiPS();
        Console.WriteLine("Phan so dang chua rut gon la:");
        psTong.hienThiPS();

        phanSo1.rutGonPS();
        phanSo2.rutGonPS(); 
        psTong.rutGonPS();

        Console.WriteLine("Phan so 1 o dang da rut gon la:");
        phanSo1.hienThiPS();
        Console.WriteLine("Phan so 2 o dang da rut gon la:");
        phanSo2.hienThiPS();
        Console.WriteLine("Phan so dang da rut gon la:");
        psTong.hienThiPS();
    }
}