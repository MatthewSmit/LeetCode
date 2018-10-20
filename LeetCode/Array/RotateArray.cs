// ReSharper disable MemberCanBeMadeStatic.Global

using System;

public partial class Solution
{
    public void Rotate(int[] nums, int k)
    {
        var copy = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            copy[(i + k) % nums.Length] = nums[i];
        }
        Array.Copy(copy, nums, copy.Length);
    }
}