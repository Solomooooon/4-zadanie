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
            double x = 8;
            double b = 9.5;

            double a = Math.Sqrt(Math.Abs(x)) + Math.Exp(Math.Sqrt(b));
            double c = Math.Log(a + Math.Pow(b, 2));
            double y = Math.Pow(a, 3) / Math.Cos(c);

            Console.WriteLine($"y = {y}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"a = {a}");

        }
    }
}
