using System;
using System.Collections.Generic;
using System.Text;

namespace Solver
{
    public class QuadraticEquationsSolver
    {
        public static Tuple<double, double> Solve(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            
            if (D < 0)  return null;

            else if (D == 0)
            {
                double x = (-b) / (2 * a);
                return Tuple.Create(x, x);
            }

            double x1 = (-b + Math.Sqrt(D)) / (2 * a);
            double x2 = (-b - Math.Sqrt(D)) / (2 * a);

            return Tuple.Create(x1, x2);
        }
    }
}
