public partial class Solution
{
    public void MoveZeroes(int[] nums)
    {
        int numberZeros;
        var i = 0;
        for (numberZeros = 0; i < nums.Length - numberZeros; i++)
        {
            nums[i] = nums[i + numberZeros];
            while (nums[i] == 0)
            {
                numberZeros++;
                if (i + numberZeros >= nums.Length)
                {
                    break;
                }
                nums[i] = nums[i + numberZeros];
            }
        }

        for (i = nums.Length - numberZeros; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}