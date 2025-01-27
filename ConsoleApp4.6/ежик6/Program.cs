using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double m = 2;
            double x = 1.1;

            double b = Math.Pow(x, 4) + Math.Pow(m, 2);
            double a = Math.Sqrt(Math.Abs(x));

            Y = Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
