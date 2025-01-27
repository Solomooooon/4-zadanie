using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._25
{
    class Class1
    {
        private double _a;
        private double _p;

        public Class1(double a, double p)
        {
            _a = a;
            _p = p;
        }

        public double CalculateT()
        {
            return Math.Pow(_a, 3) + Math.Pow(_p, 3);
        }
        public double CalculateX()
        {
            double t = CalculateT();
            return Math.Exp(Math.Sqrt(_p + _a));
        }
        public double CalculateY()
        {
            double t = CalculateT();
            double x = CalculateX();
            return Math.Pow(x, 3) / Math.Pow(t, 2);
        }

    }
}
