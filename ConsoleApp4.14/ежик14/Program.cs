using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double b = 6;
            double k = 3.4;

            double t = Math.Pow(b, 2) + Math.Pow(k, 3);
            double a = Math.Sqrt(b + t);

            Y = Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(b, 2)), 4);


            Console.WriteLine($"Y = {Y}");
        }
    }
}
