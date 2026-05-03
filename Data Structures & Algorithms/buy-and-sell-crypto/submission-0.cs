 public class Solution
 {
     public int MaxProfit(int[] prices)
     {
         int[] maxes = new int[prices.Length];
         maxes[prices.Length -1] = prices[prices.Length -1];
         for (int i = prices.Length - 2; i >= 0; i--)
         {
             maxes[i] = Math.Max(prices[i], maxes[i + 1]);
         }
         int max = 0;
         for(int i = 0;  i < prices.Length; i++)
         {
             int current = maxes[i] - prices[i];
             max = Math.Max(max, current);
         }
         return max;

     }
 }