using System;

class Prpgram
{
    static void Main()
    {
        // BT list
        List<int> lst = new List<int>();
        int i = 0;
        string ch = "";
        // Nhap ds
        Console.WriteLine("hay nhap vao ds");
        do
        {
            Console.WriteLine("\tPhan tu thu {0}: ", i + 1);
            int a = int.Parse(Console.ReadLine());
            // Phuong thuc chen them phan tu
            lst.Add(a);
            i++;

            Console.WriteLine("Ban co muon tiep tuc nhap hay k");
            ch = Console.ReadLine();
            if (ch.Equals("k"))
            {
                break;
            }
        }
        while (ch.Equals("c"));

        // Hien thi
        Console.WriteLine("\n\nds vua nhap la");
        foreach(int it in lst)
        {
            Console.WriteLine(it + "\t");
        }

        // chuyen ds sang mang 1 chieu
        int[] arr = lst.ToArray();

        // sap xep ds
        lst.Sort();

        // sap xep tren mang 1 chieu
        for (i = 0; i < (arr.Length - 1); i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    int tg = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tg;
                }
            }
        }

        // hien thi ds sau khi sap xep
        Console.WriteLine("\n\nds sau khi sx la");
        foreach (int it in lst)
        {
            Console.WriteLine(it + "\t");
        }

    }
}