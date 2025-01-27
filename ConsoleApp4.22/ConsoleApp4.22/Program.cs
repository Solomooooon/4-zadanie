using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m = 5.7;
            double p = 4;

            double t = Math.Sin(Math.Pow(m, 3));

            double x = Math.Pow(p, 2) + t;

            double y = Math.Pow(Math.Log(Math.Abs(x + t)), 4);

            Console.WriteLine($"x={t}");
            Console.WriteLine($"a={x}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
