using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double x = 2.8;
            double b = 1.3;

            double a = Math.Pow(b, 3) + Math.Log(Math.Abs(b));
            double c = Math.Pow(a, 2) + Math.Sqrt(b);

            Y = Math.Exp(x) + Math.Pow(5.8, c);
            

            Console.WriteLine($"Y = {Y}");
        }
    }
}
