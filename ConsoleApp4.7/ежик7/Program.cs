using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double k = 8.2;
            double x = 5;

            double c = Math.Sqrt(Math.Abs(x));
            double a = Math.Pow(c, 4) + Math.Pow(k, 3);
      
            Y = Math.Pow(Math.Log(a), 3) + Math.Pow(Math.Cos(x), 5);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
