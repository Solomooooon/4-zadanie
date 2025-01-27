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
            double x = 8.52;
            double c = 9;

            double b = x + Math.Pow(c, 2);
            double a = Math.Pow(Math.Sqrt(Math.Abs(b + c)), 3);
            double y = Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(a), 4) * Math.Pow(a, 2);

            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");

        }
    }
}
