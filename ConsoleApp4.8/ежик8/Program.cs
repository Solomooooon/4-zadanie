using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double b = 2.2;
            double c = 3.7;

            double a = Math.Sin(b);
            double x = a + Math.Pow((b + c), 3);


            Y = 7 * Math.Exp(Math.Sqrt(Math.Abs(x))) + Math.Pow(Math.Cos(x), 4);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
