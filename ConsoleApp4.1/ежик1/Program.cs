using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, C, Y, e, a, c;
            double x = 3.5;
            double b = 0.4;

            Console.WriteLine("Введите значение чила e");
            e = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила a");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите значение чила c");
            c = Convert.ToDouble(Console.ReadLine());

            Y = Math.Pow(e, 2 * x) + Math.Pow(9.7, c);
            C = Math.Pow(a, 2) + Math.Sqrt(b * x);
            A = Math.Log(x);

            Console.WriteLine($"A = {A}");
            Console.WriteLine($"C = {C}");
            Console.WriteLine($"Y = {Y}");
        }
    }
}
