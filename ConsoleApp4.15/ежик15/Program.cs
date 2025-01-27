using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double a = 5.5;
            double p = 4;

            double b = Math.Abs(a) + Math.Sqrt(a + Math.Pow(p, 2));
            double x = Math.Exp(b);

            Y = Math.Pow(Math.Cos(x), 3) + Math.Abs(a);


            Console.WriteLine($"Y = {Y}");
        }
    }
}
