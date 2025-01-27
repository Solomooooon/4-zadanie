using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = 8.1;
            double b = 1.6;

            double x = Math.Pow(n, 6) + Math.Pow(b, 2);

            double a = Math.Sin(Math.Pow(x, 2) + Math.Pow(b, 2));

            double y = Math.Log10(a) / Math.Log(Math.Pow(b, 3));

            Console.WriteLine($"x={x}");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
