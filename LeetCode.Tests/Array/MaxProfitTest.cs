using Xunit;

namespace LeetCode.Tests
{
    public sealed class MaxProfitTest
    {
        [Fact]
        public void Test1()
        {
            var array = new[]
            {
                7,
                1,
                5,
                3,
                6,
                4
            };
            var result = new Solution().MaxProfit(array);
            Assert.Equal(7, result);
        }

        [Fact]
        public void Test2()
        {
            var array = new[]
            {
                1,
                2,
                3,
                4,
                5
            };
            var result = new Solution().MaxProfit(array);
            Assert.Equal(4, result);
        }

        [Fact]
        public void Test3()
        {
            var array = new[]
            {
                7,
                6,
                4,
                3,
                1
            };
            var result = new Solution().MaxProfit(array);
            Assert.Equal(0, result);
        }
    }
}
