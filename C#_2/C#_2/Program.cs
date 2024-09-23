using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace b4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            x = 9;
            y = x++;
            z = x--;
            Console.WriteLine("x = {0}, y = {1} va z = {2}", x, y, z);
        }
    }
}