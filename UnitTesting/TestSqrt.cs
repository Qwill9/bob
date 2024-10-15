
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;

namespace UnitTesting
{
    public class TestSqrt
    {
        public readonly BasicCalc calculator;
        public TestSqrt()
        {
            calculator = new BasicCalc();
        }
        [Theory]
        [InlineData(4, 2)]
        [InlineData(9 , 3)]
        [InlineData(16, 4)]

        public void TestSqrtt(int a, int expectedResult)
        {
            double result = calculator.Sqrt(a);
            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void TestSqrtt2()
        {

            var result = calculator.Sqrt(6);
            Assert.Equal(2.4494897427831779, result);
        }
    }
}
