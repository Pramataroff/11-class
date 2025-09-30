using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        public double Sum(double A, double B)
        {
            return A + B;
        }
        public double Subtract(double A, double B)
        {
            return A - B;
        }
        public double Multiply(double A, double B)
        {
            return A * B;
        }
        public double Divide(double A, double B)
        {
            return A / B;
        }
        public double Power(double A, double B)
        {
            return Math.Pow(A, B);
        }

    }
}
