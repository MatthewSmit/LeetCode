// ReSharper disable MemberCanBeMadeStatic.Global
public partial class Solution
{
    public int MaxProfit(int[] prices)
    {
        var net = 0;

        for (var i = 1; i < prices.Length; i++)
        {
            if (prices[i - 1] < prices[i])
            {
                net += prices[i] - prices[i - 1];
            }
        }

        return net;
    }
}