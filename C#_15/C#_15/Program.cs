using System;

class Program
{
    static void Main()
    {
        int[] a = new int[10];
        int n, i, j, tg, k;

        // Nhap mang
        Console.WriteLine("M+Nhap vao so luong phan tu: n = ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap vao mang: ");
        for (i =  0; i < n; i++)
        {
            Console.WriteLine("\tPhan tu thu " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // hien thi mang
        Console.WriteLine("mang vua nhap la: ");
        for (i = 0; i < n;i++)
        {
            Console.WriteLine(a[i] + "     ");
        }

        // cau a
        /*
        for (i = 0; i < (n - 1); i++)
        {
            for (j = i + 1; j < n; j++)
            {
                if (a[i] > a[j])
                {
                    tg = a[i];
                    a[i] = a[j];
                    a[j] = tg;
                }
            }
        }
        Console.WriteLine("mang vua sap xep tang dan la: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "     ");
        }
        */

        // cau b
        /*
        for (i = 0; i < n; i++)
        {
            j = i + 1;
            while(j < n)
            {
                if (a[i] == a[j])
                {
                    for (k = j; k < n - 1; k++)
                    {
                        a[k] = a[k + 1];
                    }
                    n--;
                }
                else
                {
                    j++;
                }
            }
        }

        Console.WriteLine("mang vua loai bo phan tu trung la: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "     ");
        }
        */

        // cau c
        Console.WriteLine("\nNhap vao phan tu can chen: x = ");
        int x = int.Parse(Console.ReadLine());
        for (i = 0; i < n; i++)
        {
            if (a[i] > x)
            {
                for (j = n; j > i; j--)
                {
                    a[j] = a[j - i];
                }
                a[i] = x;
                n++;
                break;
            }
            else
            {
                a[n] = x;
                //n++;
                //break;
            }
        }

        Console.WriteLine("mang sau khi chen phan tu moi la: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "     ");
        }
    }
}