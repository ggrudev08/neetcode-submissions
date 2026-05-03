public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int max = 0;
        int min = prices[0]; 
        foreach (var price in prices)
        {
            max = Math.Max(max, price - min);
            min = Math.Min(min, price);
        }
        return max;
    }
}