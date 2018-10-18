// ReSharper disable MemberCanBeMadeStatic.Global

public sealed partial class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        var lastValidIndex = 0;
        for (var currentIndex = 1; currentIndex < nums.Length; currentIndex++)
        {
            if (nums[currentIndex] > nums[lastValidIndex])
            {
                nums[++lastValidIndex] = nums[currentIndex];
            }
        }

        return lastValidIndex + 1;
    }
}