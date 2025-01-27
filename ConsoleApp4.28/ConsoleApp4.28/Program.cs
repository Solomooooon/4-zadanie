using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double b = 2.19;
            double k = 1.7;

            double t = Math.Pow(k, 2) + Math.Sqrt(b);

            double a = b + Math.Pow(t, 2) * Math.Exp(1);

            double y = Math.Pow(Math.Cos(Math.Pow(a, 3) + b), 4);

            Console.WriteLine($"t={t}");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
