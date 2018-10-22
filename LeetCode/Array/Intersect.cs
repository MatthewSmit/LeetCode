using System;

public partial class Solution
{
    public int[] Intersect(int[] nums1, int[] nums2)
    {
        Array.Sort(nums1);
        Array.Sort(nums2);

        var result = new int[Math.Min(nums1.Length, nums2.Length)];
        var size = 0;

        for (int i = 0, j = 0; i < nums1.Length && j < nums2.Length; )
        {
            var v1 = nums1[i];
            var v2 = nums2[j];
            if (v1 == v2)
            {
                result[size++] = v1;
                i++;
                j++;
            }
            else if (v1 < v2)
            {
                i++;
            }
            else
            {
                j++;
            }
        }

        Array.Resize(ref result, size);
        return result;
    }
}