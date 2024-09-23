using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];
        int n, i, s = 0, max;
        double tb;

        // nhap vao mang
        Console.WriteLine("Nhap vao so luong phan tu n = ");
        n = int.Parse(Console.ReadLine());
        Console.WriteLine("Nhap vao gia tri cho mang");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("\tPhan tu thu " + (i+1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // Hien thi
        Console.WriteLine("Mang vua nhap la");
        for (i = 0; i < n;i++)
        {
            Console.WriteLine(a[i] + "     ");
        }

        // cau a:
        // Tinh tong
        for (i = 0; i < n; i ++)
        {
            s += a[i];
        }
        Console.WriteLine("\nTong cac phan tu trong mang la: {0}", s);
        Console.WriteLine("\nTB cong cac phan tu la: {0}", (double)s / n);

        // cau b:
        // tim max
        max = a[0];
        for (i = 0; i < n; ++i)
        {
            if (max < a[i])
            {
                max = a[i];
            }
        }

        Console.WriteLine("Phan tu co gia tri lon nhat la: " + max);
        Console.WriteLine("Vi tri phan tu co gia tri bang max la: ");
        for (i = 0; i < n; i++)
        {
            if (a[i] == max)
            {
                Console.WriteLine((i+1) + "     ");
            }
        }

        // cau c:
        // nhap tu ban phim, tim va in ra vi tri
        Console.WriteLine("\nNhap vao phan tu x: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Vi tri phan tu trong mang co gia tri bang x la: ");
        for (i = 0; i < n; i++)
        {
            if (a[i] == x)
            {
                Console.WriteLine((i + 1) + "   ");
            }
        }
    }
}