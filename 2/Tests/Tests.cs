global using Xunit;
using __2;

namespace Tests
{
    public class Tests
    {
        [Theory]
        [InlineData(9669, 9969)]
        [InlineData(9996, 9999)]
        [InlineData(9999, 9999)]
        public void GetMinimumSum_Tests(int num, int expectMinimumSum)
        {
            var result = _2.GetMaximum69Number(num);

            Assert.Equal(expectMinimumSum, result);
        }
    }
}