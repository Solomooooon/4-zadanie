using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double b = 7;
            double x = 2;

            double a = Math.Pow((b + x), 3);
            double c = Math.Log(Math.Abs(b));

            Y = Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));


            Console.WriteLine($"Y = {Y}");
        }
    }
}
