using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = 6.2;
            double b = 1.8;

            double a = b * Math.Pow(t, 2);

            double x = Math.Pow(a, 3)+Math.Sqrt(t+b);

            double y = Math.Cos(Math.Pow(x, 5)) - b * Math.Pow(Math.Sin(x), 2);

            Console.WriteLine($"a={a}");
            Console.WriteLine($"x={x}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
