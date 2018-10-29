using LeetCode.Coderbyte;
using Xunit;

namespace LeetCode.Tests
{
    public sealed class CorrectPathTest
    {
        [Fact]
        public void Test1()
        {
            const string input = "???rrurdr?";
            const string output = "dddrrurdrd";
            var result = CorrectPathImpl.CorrectPath(input);
            Assert.Equal(output, result);
        }

        [Fact]
        public void Test2()
        {
            const string input = "drdr??rrddd?";
            const string output = "drdruurrdddd";
            var result = CorrectPathImpl.CorrectPath(input);
            Assert.Equal(output, result);
        }

        [Fact]
        public void Test3()
        {
            const string input = "rd?u??dld?ddrr";
            const string output = "rdrurrdldlddrr";
            var result = CorrectPathImpl.CorrectPath(input);
            Assert.Equal(output, result);
        }
    }
}
