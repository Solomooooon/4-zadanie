using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 0.3;
            double x = 5.2;

            double t = x * Math.Pow(b, 2) + Math.Sqrt(x);

            double a = Math.Log(Math.Abs(t * x + Math.Pow(b, 2)));

            double y = Math.Pow(Math.Log10(1), (a + b)) + Math.Pow(a, 2) / a + t;

            Console.WriteLine($"t={t}");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
