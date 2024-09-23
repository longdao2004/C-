using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];

        // nhap vap
        Console.WriteLine("Nhap vao so luong phan tu: n = ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap vao gia tri trong mang: ");
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("\tPhan tu thu " + (i + 1) + "la: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // duyet mang
        Console.WriteLine("Duyet mang theo form");
        for (int i = 0;i < n; i++)
        {
            Console.WriteLine(a[i] + "    ");
        }

        Console.WriteLine("\nDuyet mang theo foreach");
        foreach (int i in a)
        {
            Console.WriteLine(i + "     ");
        }

    }
}