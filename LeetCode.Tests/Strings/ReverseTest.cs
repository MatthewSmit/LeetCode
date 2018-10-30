using Xunit;

namespace LeetCode.Tests
{
    public sealed class ReverseTest
    {
        [Fact]
        public void Test1()
        {
            var result = new Solution().Reverse(123);
            Assert.Equal(321, result);
        }

        [Fact]
        public void Test2()
        {
            var result = new Solution().Reverse(-123);
            Assert.Equal(-321, result);
        }

        [Fact]
        public void Test3()
        {
            var result = new Solution().Reverse(120);
            Assert.Equal(21, result);
        }
    }
}
