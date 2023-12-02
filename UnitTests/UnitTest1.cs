using FizzBuzz;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void Test1(int testNumber, string expectedResult)
        {
            var result = FizzBuzzService.CheckResult(testNumber);

            Assert.Equal(result, expectedResult);
        }
    }
}