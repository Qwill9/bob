using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;
using Xunit.Sdk;

namespace UnitTesting
{
    public class TestIsPerfectNumber
    {
        public readonly BasicCalc calculator;
        public TestIsPerfectNumber()
        {
            calculator = new BasicCalc();
        }
        [Fact]
        public void SolveQuadraticEquationTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => calculator.IsPerfectNumber(-6));
        }

        [Fact]
        public void TestIsPerfectNumber1()
        {

            bool result = calculator.IsPerfectNumber(6);
            Assert.Equal(true, result);
        }

        [Theory]
        [InlineData(4, false)]
        [InlineData(6, true)]
        [InlineData(1, false)]

        public void TestIsPerfectNumber2(int a, bool expectedResult)
        {
            bool result = calculator.IsPerfectNumber(a);
            Assert.Equal(expectedResult, result);
        }
    }
}
