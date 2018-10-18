using Xunit;

namespace LeetCode.Tests
{
    public sealed class RemoveDuplicatesTest
    {
        [Fact]
        public void Test1()
        {
            var array = new[]
            {
                1,
                1,
                2
            };
            var result = new Solution().RemoveDuplicates(array);
            Assert.Equal(2, result);
            Assert.Equal(1, array[0]);
            Assert.Equal(2, array[1]);
        }

        [Fact]
        public void Test2()
        {
            var array = new[]
            {
                0,
                0,
                1,
                1,
                1,
                2,
                2,
                3,
                3,
                4
            };
            var result = new Solution().RemoveDuplicates(array);
            Assert.Equal(5, result);
            Assert.Equal(0, array[0]);
            Assert.Equal(1, array[1]);
            Assert.Equal(2, array[2]);
            Assert.Equal(3, array[3]);
            Assert.Equal(4, array[4]);
        }
    }
}
