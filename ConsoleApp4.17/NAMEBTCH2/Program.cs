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
            double x = 0.9;
            double t = 2;

            double b = Math.Pow(Math.Log(Math.Abs(x)), 2);
            double a = t * x + Math.Abs(Math.Sqrt(b));
            double y = Math.Pow(Math.Cos(a + Math.Pow(b,3)),3);

            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"y = {y}");

        }
    }
}
