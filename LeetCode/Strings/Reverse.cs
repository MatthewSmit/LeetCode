using System;

public partial class Solution
{
    public int Reverse(int x)
    {
        // Since -int.MinValue == int.MinValue
        if (x == int.MinValue)
        {
            return 0;
        }

        if (x < 0)
        {
            return -Reverse(-x);
        }

        var str = x.ToString().ToCharArray();
        Array.Reverse(str);
        if (int.TryParse(new string(str), out var result))
        {
            return result;
        }

        return 0;
    }
}