using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = -3;
            double a = 76;

            double c = Math.Pow(t, 2) + Math.Sqrt(a);

            double x = Math.Log10(Math.Abs(c * t)) + Math.Pow(a, 2);

            double y = Math.Tan(4*x)+Math.Sin(Math.Pow(x,2));

            Console.WriteLine($"c={c}");
            Console.WriteLine($"x={x}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
