using TestingLib.Math;

namespace UnitTesting
{
    public class Tests
    {
        public readonly BasicCalc calculator;
        public Tests()
        {
            calculator = new BasicCalc();
        }
        [Fact]
        public void TestGCD()
        {

            var result = calculator.GCD(1, 5);
            Assert.Equal(1, result);
        }

        [Theory]
        [InlineData(4, 1)]
        [InlineData(9, 1)]
        [InlineData(16, 1)]

        public void TestGCD2(int a, int expectedResult)
        {
            double result = calculator.GCD(1, 5);
            Assert.Equal(expectedResult, result);
        }

    }
}
