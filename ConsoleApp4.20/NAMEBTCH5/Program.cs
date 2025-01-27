using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        public void Main(string[] args)
        {
            double x = 1.4;
            double p = 1.6;

            double b = Math.Pow(x, 4) + Math.Log(Math.Pow(p, 4));
            double a = Math.Log10(Math.Abs(x));
            double y = Math.Pow(Math.Sin(a * x), 3) + Math.Sqrt(b) * (Math.Cos(Math.Pow(x, 2)));

            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");

        }
    }
}
