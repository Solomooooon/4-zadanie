using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double t = 4.1;
            double p = 3;

            double k = Math.Sqrt(p * t);
            double x = p * Math.Pow(t, 2) + Math.Sqrt(k);

            Y = Math.Pow(Math.Tan(Math.Pow(x, 2)), 3) + k * t;

            Console.WriteLine($"Y = {Y}");
        }
    }
}
