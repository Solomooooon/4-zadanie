using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double t = 2;
            double b = 8.1;

            double a = Math.Sqrt(b+Math.Pow(t,2));

            double x = Math.Pow(Math.Cos(b), 2) + Math.Pow(Math.Sin(a), 2);

            double y = Math.Pow(x, 2) + Math.Pow(Math.Sqrt(Math.Abs(x)), 3);

            Console.WriteLine($"a={a}");
            Console.WriteLine($"x={x}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
