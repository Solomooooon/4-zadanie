using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double k = 1;
            double m = 1.8;

            double c = Math.Pow(Math.Cos(m), 2) + k;
            double x = Math.Exp(m * k);

            Y = Math.Pow(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(c, 2)), 3);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
