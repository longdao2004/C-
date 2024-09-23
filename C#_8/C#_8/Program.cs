using System;

class Program
{
    static void Main()
    {
        // chuyen tu he 10 sang 2
        int[] arr = new int[17];
        int i = 0;
        int num;

        // Nhap 
        Console.WriteLine("Nhap vao so he 10 : ");
        num = int.Parse(Console.ReadLine());

        while (num > 0)
        {
            arr[i++] = num % 2;
            num = num / 2;
        }

        // hoan doi vi tri doi xung
        int length = i;
        for (i = 0; i < length / 2; i++)
        {
            int tg = arr[i];
            arr[i] = arr[length - 1 - i];
            arr[length - 1 - i] = tg;
        }

        // in ra
        Console.WriteLine("So nhi phan tuong ung la: ");
        for (i = 0; i < length; i++)
        {
            Console.Write(arr[i]);
        }
    }
}