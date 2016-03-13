using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public static class MathOperations
    {
        public static double Sqrt(double number, int power, double eps = 0.0001)
        {
            if (number < 0)
                throw new ArgumentException("Can not sqrt negative number");
            if (eps < 0 || power <= 0)
                throw new ArgumentOutOfRangeException();
            Console.WriteLine(eps);
            double result = 1;

            while (true)
            {
                double powResult = Math.Pow(result, power);
                if (Math.Abs(powResult - number) <= eps)
                    return result;
                result = (1.0 / power) * ((power - 1) * result + number / Math.Pow(result, power - 1));
            }
        }
    }
}
