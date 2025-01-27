using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._30
{
    class Class1
    {
        private double _b;
        private double _t;

        public Class1(double b, double t)
        {
            _b = b;
            _t = t;
        }

        public double CalculateA()
        {
            return _t + Math.Pow(_b, 3);
        }
        public double CalculateX()
        {
            double a = CalculateA();
            return Math.Pow(_t, 2) + Math.Sqrt(Math.Abs(a + _b));
        }
        public double CalculateY()
        {
            double x = CalculateX();
            double a = CalculateA();
            return Math.Pow(Math.Log10(Math.Abs(x + Math.Pow(a, 2))), 5);
        }
    }
}
