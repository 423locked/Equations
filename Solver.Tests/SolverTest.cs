using NUnit.Framework;
using System;
using System.Linq;

namespace Solver.Tests
{
    public class SolverTests
    {
        private static void TestEquation(double a, double b, double c, Tuple<double, double> expected)
        {
            Tuple<double, double> solution = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(expected.Item1, solution.Item1);
            Assert.AreEqual(expected.Item2, solution.Item2);
        }

        [Test]
        public void TwoRootEquation()
        {
            TestEquation(1, -3, 2, Tuple.Create((double)2, (double)1));
        }

        [Test]
        public void SingleRootEquation()
        {
            TestEquation(1, -2, 1, Tuple.Create((double)1, (double)1));
        }

        [Test]
        public void NegativeDiscriminant()
        {
            // Assign, Act, Assert
            double a = 1, b = 1, c = 1;

            Tuple<double, double> solution = QuadraticEquationsSolver.Solve(a, b, c);

            Assert.AreEqual(null, solution);
        }
    }
}