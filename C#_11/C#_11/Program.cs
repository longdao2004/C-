using System;

class Program
{
    static void Main()
    {
        // Dictionary
        /*
        Dictionary<int, string> dic1 = new Dictionary<int, string>();
        dic1.Add(1, "One");
        dic1.Add(2, "Two");
        dic1.Add(3, "Three");

        foreach(KeyValuePair<int, string> item in dic1)
        {
            int key = item.Key;
            string value = item.Value;
            Console.Write("Key: {0} - Value: {1}", key, value);

        }

        for (int i = 0; i < dic1.Count; i++)
        {
            int key = dic1.Keys.ElementAt(i);
            string value = dic1[key];

            Console.WriteLine("Key: {0} - Value: {1}", key, value);
        }
        */

        Dictionary<string, string> dic = new Dictionary<string, string>();
        List<string> lst1 = new List<string>(5);
        List<string> lst2 = new List<string>(5);

        Console.WriteLine("Ban hay nhap ten cac quoc gia va ten cac thu do: ");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("nhap ten qg thu {0}: ", i + 1);
            string tenQG = Console.ReadLine();
            lst1.Add(tenQG);

            Console.WriteLine("\tten thanh pho: ");
            string tenTP = Console.ReadLine();
            lst2.Add(tenTP);
        }

        // do lst1 va lst2 vao dictionary
        for (int i = 0;i < 5;i++)
        {
            dic.Add(lst1[i], lst2[i]);
        }

        // hien thi dic
        foreach (KeyValuePair<string, string> item in dic)
        {
            Console.WriteLine("QG: {0} - Thu do: {1}", item.Key, item.Value);
        }

        foreach (KeyValuePair<string, string> item in dic)
        {
            if (item.Key.Equals("Viet Nam"))
            {
                Console.WriteLine("Thu do la: " + item.Value);
            }
        }
    }
}