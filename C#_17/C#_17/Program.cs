using System;

class Program
{
    static void Main()
    {
        List<int> lst = new List<int>() { 6, 10, 1, 7, 4 };
        Console.WriteLine("Ds khoi tao la: ");
        foreach (int i in lst)
        {
            Console.WriteLine(i + "     ");
        }

        // cau a
        Console.WriteLine("\n\nNhap vao gia tri can chen: y = ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao vi tri can chen: m = ");
        int m = int.Parse(Console.ReadLine());

        // chen phan tu
        lst.Insert((m - 1), x);

        Console.WriteLine("Ds sau khi chen la: ");
        foreach (int i in lst)
        {
            Console.WriteLine(i + "     ");
        }

        // cau b
        Console.WriteLine("nhap vao gia tri can sua: y = ");
        int y = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao vi tri can sua: k = ");
        int k = int.Parse(Console.ReadLine());

        lst[(k-1)] = y;
        Console.WriteLine("Ds sau khi sua la: ");
        foreach (int i in lst)
        {
            Console.WriteLine(i + "     ");
        }

        // cau c
        Console.WriteLine("nhap vao vi tri can xoa: q = ");
        int q = int.Parse(Console.ReadLine());
        lst.RemoveAt((q - 1));
        Console.WriteLine("Ds sau khi xoa la: ");
        foreach (int i in lst)
        {
            Console.WriteLine(i + "     ");
        }
    }
}