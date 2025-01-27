using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4._21
{
    class Class1
    {
        private double _n;
        private double _b;

        public Class1(double n, double b)
        {
            _n = n;
            _b = b;
        }

        public double CalculateX()
         {
            return Math.Pow(_n, 6) + Math.Pow(_b, 2);
         }
        public double CalculateA()
        {
            double x = CalculateX();
            return Math.Sin(Math.Pow(x, 2) + Math.Pow(_b, 2));
        }
        public double CalculateY()
        {
            double a = CalculateA();
            return Math.Log10(a) / Math.Log(Math.Pow(_b, 3));
        }
    }
}
