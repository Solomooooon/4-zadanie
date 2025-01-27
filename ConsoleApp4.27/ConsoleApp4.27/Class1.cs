using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._27
{
    class Class1
    {
        private double _t;
        private double _a;

        public Class1(double t, double a)
        {
            _t = t;
            _a = a;
        }

        public double CalculateC()
        {
            return Math.Pow(_t, 2) + Math.Sqrt(_a);
        }
        public double CalculateX()
        {
            double c = CalculateC();
            return Math.Log10(Math.Abs(c * _t)) + Math.Pow(_a, 2);
        }
        public double CalculateY()
        {
            double c = CalculateC();
            double x = CalculateX();
            return Math.Tan(4 * x) + Math.Sin(Math.Pow(x, 2));
        }
    }
}
