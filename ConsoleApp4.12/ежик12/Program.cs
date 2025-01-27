using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double q = 2;
            double b = 1.8;

            double t = Math.Pow(b, 3) + Math.Exp(Math.Sqrt(q));
            double x = Math.Pow(t, 3) + Math.Pow(b, 2);

            Y = Math.Pow(Math.Atan(Math.Abs(x)), 2);


            Console.WriteLine($"Y = {Y}");
        }
    }
}
