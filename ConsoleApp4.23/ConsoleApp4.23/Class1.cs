using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._23
{
    class Class1
    {
        private double _x;
        private double _b;

        public Class1(double b, double x)
        {
            _b = b;
            _x = x;
        }

        public double CalculateT()
        {
            return _x * Math.Pow(_b, 2) + Math.Sqrt(_x);
        }
        public double CalculateA()
        {
            double t = CalculateT();
            return Math.Log(Math.Abs(t * _x + Math.Pow(_b, 2)));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double t = CalculateT();
            return Math.Pow(Math.Log10(1), (a + _b)) + Math.Pow(a, 2) / a + t;
        }
    }
}
