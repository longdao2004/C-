using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhap vao chuoi bat ky: ");
        string str = Console.ReadLine();
        //char ch = 'a';

        //str = str.ToUpper();

        //string[] arr = str.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        //foreach(string item in arr)
        //{
        //    Console.WriteLine(item);
        //}

        char[] arr = str.ToCharArray();
        foreach (char item in arr)
        {
            Console.WriteLine($"{item}");
        }
    }
}