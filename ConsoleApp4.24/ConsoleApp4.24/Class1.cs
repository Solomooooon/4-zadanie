using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._24
{
    class Class1
    {
        private double _t;
        private double _b;

        public Class1(double b, double t)
        {
            _b = b;
            _t = t;
        }

        public double CalculateA()
        {
            return _b * Math.Pow(_t, 2);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(a, 3) + Math.Sqrt(_t + _b);
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double x = CalculateX();
            return Math.Cos(Math.Pow(x, 5)) - _b * Math.Pow(Math.Sin(x), 2);
        }
    }
}
