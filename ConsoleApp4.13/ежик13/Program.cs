using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double x = 1.9;
            double a = -0.9;

            double w = Math.Pow(x, 2) * Math.Sqrt(Math.Abs(a + x)); 
            double z = Math.Pow(Math.Cos(a), 2) + Math.Pow(w, 2);

            Y = a * Math.Pow(z, 7) + Math.Pow(Math.Sin(w), 2);


            Console.WriteLine($"Y = {Y}");
        }
    }
}
