using Xunit;

namespace LeetCode.Tests
{
    public sealed class RotateArrayTest
    {
        [Fact]
        public void Test1()
        {
            var array = new[]
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7
            };
            new Solution().Rotate(array, 3);
            Assert.Equal(5, array[0]);
            Assert.Equal(6, array[1]);
            Assert.Equal(7, array[2]);
            Assert.Equal(1, array[3]);
            Assert.Equal(2, array[4]);
            Assert.Equal(3, array[5]);
            Assert.Equal(4, array[6]);
        }

        [Fact]
        public void Test2()
        {
            var array = new[]
            {
                -1,
                -100,
                3,
                99
            };
            new Solution().Rotate(array, 2);
            Assert.Equal(3, array[0]);
            Assert.Equal(99, array[1]);
            Assert.Equal(-1, array[2]);
            Assert.Equal(-100, array[3]);
        }
    }
}
