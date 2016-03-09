using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MathOperations
    {
        public static double Sqrt(double a, double n, double eps = 0.0001)
        {
            if (a < 0)
                throw new Exception("Can not sqrt a negative number");
            if (eps < 0)
                throw new ArgumentOutOfRangeException();
            double x = 1;
            while (true)
            {
                double val = Math.Pow(x, n);
                if (Math.Abs(val - a) <= eps)
                    return x;
                x = (1 / n) * ((n - 1) * x + a / Math.Pow(x, n - 1));
            }
        }
    }
}
