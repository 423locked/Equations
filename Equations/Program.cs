using System;
using Solver;

namespace Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            var solutions = QuadraticEquationsSolver.Solve(1, -3, 2);

            Console.WriteLine($"x1={solutions.Item1}, x2={solutions.Item2}");
        }
    }
}
