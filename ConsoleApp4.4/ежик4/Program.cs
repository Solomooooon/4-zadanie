using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double x = 2.1;
            double t = -6;

            double a = Math.Log(x);
            double b = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(t, 2));
            Y = Math.Pow(Math.Sqrt(Math.Abs(a - b * x)), 5);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
