using Xunit;

namespace LeetCode.Tests
{
    public sealed class IntersectTest
    {
        [Fact]
        public void Test1()
        {
            var array1 = new[]
            {
                1,
                2,
                2,
                1
            };
            var array2 = new[]
            {
                2,
                2
            };
            var result = new Solution().Intersect(array1, array2);
            Assert.Equal(2, result.Length);
            Assert.Equal(2, result[0]);
            Assert.Equal(2, result[1]);
        }

        [Fact]
        public void Test2()
        {
            var array1 = new[]
            {
                4,
                9,
                5
            };
            var array2 = new[]
            {
                9,
                4,
                9,
                8,
                4
            };
            var result = new Solution().Intersect(array1, array2);
            Assert.Equal(2, result.Length);
            Assert.Equal(4, result[0]);
            Assert.Equal(9, result[1]);
        }
    }
}
