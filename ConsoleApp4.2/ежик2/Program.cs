using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Y;
            double x = 1.3;
            double k = 4;
            double e;

            Console.WriteLine("Введите значение чила e");
            e = Convert.ToDouble(Console.ReadLine());

            double a = Math.Log(Math.Abs(x));
            double b = Math.Pow(e, 2 * x) + a * x;

            Y = x * Math.Pow(a, 3) + Math.Pow(b, 2);

            Console.WriteLine($"Y = {Y}");
        }
    }
}
