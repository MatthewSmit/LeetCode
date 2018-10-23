using Xunit;

namespace LeetCode.Tests
{
    public sealed class MoveZeroesTest
    {
        [Fact]
        public void Test1()
        {
            var array = new[]
            {
                0,
                1,
                0,
                3,
                12
            };
            new Solution().MoveZeroes(array);
            Assert.Equal(new[]
            {
                1,3,12,0,0
            }, array);
        }

        [Fact]
        public void Test2()
        {
            var array = new[]
            {
                0
            };
            new Solution().MoveZeroes(array);
            Assert.Equal(new[]
            {
                0
            }, array);
        }
    }
}
