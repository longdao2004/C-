using C__18_OOP;
using System;
class Program
{
    static void Main()
    {
        TamGiac tamGiac = new TamGiac();
        Console.WriteLine("Nhap vao tam giac");
        tamGiac.Nhap();
        Console.WriteLine("\ndien tich la" + tamGiac.TinhDT() + "\n chu vi la" + tamGiac.TinhCV);
    }
}