using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Class1
    {
        private double _x;
        private double _p;

        public Class1(double x, double p)
        {
            _x = x;
            _p = p;
        }

        public double CalculateB()
        {
            return Math.Pow(_x, 4) + Math.Log(Math.Pow(_p, 4));
        }
        public double CalculateA()
        {
            double b = CalculateB();
            return Math.Log10(Math.Abs(_x));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            double b = CalculateB();
            return Math.Pow(Math.Sin(a * _x), 3) + Math.Sqrt(b) * (Math.Cos(Math.Pow(_x, 2)));
        }
    }
}