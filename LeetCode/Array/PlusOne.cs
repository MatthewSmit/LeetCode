public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        var overflow = true;
        for (var i = digits.Length - 1; i >= 0; i--)
        {
            overflow = ++digits[i] == 10;
            if (overflow)
            {
                digits[i] = 0;
            }
            else
            {
                break;
            }
        }

        if (overflow)
        {
            var result = new int[digits.Length + 1];
            result[0] = 1;
            return result;
        }

        return digits;
    }
}