using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;
using Xunit.Sdk;

namespace UnitTesting
{
    public class TestSolveQuadraticEquation
    {
        public readonly BasicCalc calculator;
        public TestSolveQuadraticEquation()
        {
            calculator = new BasicCalc();
        }
        [Fact]
        public void SolveQuadraticEquationTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.IsPerfectNumber(-6));
        }
    }
}
