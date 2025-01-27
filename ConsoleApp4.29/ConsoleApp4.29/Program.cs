using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 4.3;
            double a = 6;

            double x = Math.Exp(2 * a) + Math.Sqrt(b);

            double p = x * (a + Math.Pow(b, 3));

            double y = Math.Pow(Math.Log(Math.Abs(p)), 3) + x;

            Console.WriteLine($"x={x}");
            Console.WriteLine($"p={p}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
