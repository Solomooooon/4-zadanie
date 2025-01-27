using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 2;
            double p = 2.6;

            double t = Math.Pow(a,3)+Math.Pow(p,3);

            double x = Math.Exp(Math.Sqrt(p + a));

            double y = Math.Pow(x,3)/Math.Pow(t,2);

            Console.WriteLine($"a={a}");
            Console.WriteLine($"x={x}");
            Console.WriteLine($"y={y}");
            Console.ReadLine();
        }
    }
}
