using System.Collections.Generic;

public partial class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}