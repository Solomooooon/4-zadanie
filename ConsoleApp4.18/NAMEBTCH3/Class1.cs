using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNAMEBTCH3
{
    class Class1
    {
        private double _x;
        private double _b;

        public Class1(double x, double b)
        {
            _x = x;
            _b = b;
        }

        public double CalculateA()
        {
            return Math.Sqrt(Math.Abs(_x)) + Math.Exp(Math.Sqrt(_b));
        }
        public double CalculateC()
        {
            double a = CalculateA();
            return Math.Log(a + Math.Pow(_b, 2));
        }
        public double CalculateY()
        {
            double c = CalculateC();
            double a = CalculateA();
            return Math.Pow(a, 3) / Math.Cos(c);
        }
    }
}