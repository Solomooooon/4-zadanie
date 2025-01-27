using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ежик1
{
    internal class Class1
    {
            
        private double _e;
        private double _a;
        private double _c;
        private double _x = 3.5;
        private double _b = 0.4;

        public Class1(double e, double a, double c, double x, double b)
        {
            _e = e;
            _a = a;
            _c = c;
            _x = x;
            _b = b;

        }
        public void Y()
        {
            Console.WriteLine($"Y = {Math.Pow(_e, 2 * _x) + Math.Pow(9.7, _c)}");
        }
        public void C()
        {
            Console.WriteLine($"C = {Math.Pow(_a, 2) + Math.Sqrt(_b * _x)}");
        }
        public void A()
        {
            Console.WriteLine($"A = {Math.Log(_x)}");
        }
    }
}

