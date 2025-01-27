using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = 3;
            double b = 4.2;

            double a = t + Math.Pow(b, 3);

            double x = Math.Pow(t, 2) + Math.Sqrt(Math.Abs(a + b));

            double y = Math.Pow(Math.Log10(Math.Abs(x + Math.Pow(a, 2))), 5);

            Console.WriteLine($"a={a}");
            Console.WriteLine($"x={a}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
