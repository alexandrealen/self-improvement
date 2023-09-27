global using Xunit;
using MinimumSum;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(2932, 52)]
        [InlineData(4009, 13)]
        public void GetMinimumSum_Tests(int num, int expectMinimumSum)
        {
            var result = _1.GetMinimumSum(num);

            Assert.Equal(expectMinimumSum, result);
        }
    }
}