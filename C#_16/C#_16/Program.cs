using System;

class Program
{
    static void Main()
    {
        int[] a = new int[20];
        int[] b = new int[20];
        int[] c = new int[20];
        int n, i, j;
        int m1 = 0, m2 = 0; // m1 cho mang +, m2 cho mang -

        // Nhap mang
        Console.WriteLine("Nap ao so luong phan tu n = ");
        n = int.Parse(Console.ReadLine());

        Console.WriteLine("Nhap vao gia tri phan tu cho mang: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine("\tPhan tu thu " + (i + 1) + ": ");
            a[i] = int.Parse(Console.ReadLine());
        }

        // hien thi mang
        Console.WriteLine("Mang vua nhap la: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "      ");
        }

        // loai bo  phan tu = 0
        for (i = 0; i < n; i++)
        {
            if (a[i] == 0)
            {
                for (j = i; j < (n - 1); j++)
                {
                    a[j] = a[j + 1];
                }
                n--;
                i--;
            }
        }

        // Console.WriteLine("\nMang sau khi loai bo gia tri bang 0 la: ");
        for (i = 0; i < n; i++)
        {
            Console.WriteLine(a[i] + "      ");
        }

        // tach mang
        for (i = 0; i < n; i++)
        {
            if (a[i] > 0)
            {
                b[m1++] = a[i];
                //m1++;
            }
            else
            {
                c[m2++] = a[i];
            }
        }
        Console.WriteLine("\n\nMang chua phan tu duong la: ");
        for (i = 0; i < m1; i++)
        {
            Console.WriteLine(b[i] + "      ");
        }

        Console.WriteLine("\n\nMang chua phan tu duong la: ");
        for (i = 0; i < m2; i++)
        {
            Console.WriteLine(c[j] + "      ");
        }
    }
}