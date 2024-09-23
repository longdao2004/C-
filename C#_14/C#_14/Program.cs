using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];

        // Nhap mang
        Console.WriteLine("Nhap vao so luong phan tu n = ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\tPhan tu thu  " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Mang vua nhap la: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "      ");
        }

        // cau a
        Console.WriteLine("Nhap vao gia tri phan tu can chen x: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao gia tri can chenn m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = n; i >= m; i--)
        {
            a[i] = a[i - 1];
        }
        a[m - 1] = x;
        n++;

        // hien thi
        Console.WriteLine("Mang sau khi chen la: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "      ");
        }
    }
}