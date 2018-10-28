using Xunit;

namespace LeetCode.Tests
{
    public sealed class RotateTest
    {
        [Fact]
        public void Test1()
        {
            var array = new[,]
            {
                {
                    1,
                    2,
                    3
                },
                {
                    4,
                    5,
                    6
                },
                {
                    7,
                    8,
                    9
                }
            };
            var solution = new[,]
            {
                {
                    7,
                    4,
                    1
                },
                {
                    8,
                    5,
                    2
                },
                {
                    9,
                    6,
                    3
                }
            };

            new Solution().Rotate(array);

            for (var x = 0; x < solution.GetLength(0); x++)
            {
                for (var y = 0; y < solution.GetLength(1); y++)
                {
                    Assert.Equal(solution[x, y], array[x, y]);
                }
            }
        }

        [Fact]
        public void Test2()
        {
            var array = new[,]
            {
                {
                    5,
                    1,
                    9,
                    11
                },
                {
                    2,
                    4,
                    8,
                    10
                },
                {
                    13,
                    3,
                    6,
                    7
                },
                {
                    15,
                    14,
                    12,
                    16
                }
            };
            var solution = new[,]
            {
                {
                    15,
                    13,
                    2,
                    5
                },
                {
                    14,
                    3,
                    4,
                    1
                },
                {
                    12,
                    6,
                    8,
                    9
                },
                {
                    16,
                    7,
                    10,
                    11
                }
            };

            new Solution().Rotate(array);

            for (var x = 0; x < solution.GetLength(0); x++)
            {
                for (var y = 0; y < solution.GetLength(1); y++)
                {
                    Assert.Equal(solution[x, y], array[x, y]);
                }
            }
        }
    }
}
