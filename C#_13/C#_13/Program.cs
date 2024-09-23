using System;
using System.Data;

class Program
{
    static void Main()
    {
        int[] a = new int[10];
        int n, kt = 1;

        // Nhap mang
        Console.WriteLine("Nhap vao so luong phan tu n = ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap vao day so: ");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\tPhan tu thu " + (i+1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // hien thi
        Console.WriteLine("Day so vua nhap la: ");
        for (int i = 0;i < n; i++)
        {
            Console.WriteLine(a[i] + "      ");
        }

        // cau a
        /*
        kt = KiemTraDayTang(a, n);

        if (kt == 1)
        {
            Console.WriteLine("Day tang!");
        }
        else
        {
            Console.WriteLine("Day k tang!");
        }
    }

    private static int KiemTraDayTang(int[] a, int n)
    {
        for (int i = 0; i < (n - 1); i++)
        {
            if (a[i] > a[i + 1])
            {
                return 0;
            }
        }
        return 1;
    */

        // cau b
        /*
        kt = KiemTraCSC(a, n);

        if (kt == 1)
        {
            Console.WriteLine("Day CSC!");
        }
        else
        {
            Console.WriteLine("Day k la CSC!");
        }
    }

    private static int KiemTraCSC(int[] a, int n)
    {
        int d = a[1] - a[0];
        for (int i = 0; i < (n - 1); i++)
        {
            if ((a[i] + d) != a[i + 1])
            {
                return 0;
            }
        }
        return 1;
        */

        // cau c
        kt = KiemTraDoiXung(a, n);

        if (kt == 1)
        {
            Console.WriteLine("Day doi xung!");
        }
        else
        {
            Console.WriteLine("Day k doi xung!");
        }
    }

    private static int KiemTraDoiXung(int[] a, int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            if (a[i] != a[n - i -1])
            {
                return 0;
            }
        }
        return 1;
    }
}
