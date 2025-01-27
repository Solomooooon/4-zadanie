using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y, e;
            double x = 2.1;
            double p = 1;

            Console.WriteLine("Введите значение чила e");
            e = Convert.ToDouble(Console.ReadLine());

            double a = Math.Pow(e, Math.Sqrt(Math.Abs(x)));
            double b = Math.Sin(Math.Pow(p, 2)) + Math.Pow(x, 3);
            Y = Math.Pow(a, 3) / Math.Pow(b, 2);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
