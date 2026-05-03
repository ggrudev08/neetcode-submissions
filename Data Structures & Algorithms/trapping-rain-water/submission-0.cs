 public class Solution
 {
     public int Trap(int[] height)
     {
         int[] prefix = new int[height.Length];
         prefix[0] = height[0];
         for (int i = 1; i < height.Length; i++)
         {
             prefix[i] = Math.Max(height[i], prefix[i - 1]);
         }
         int[] suffix = new int[height.Length];
         suffix[height.Length -1] = height[height.Length - 1];
         for(int i = height.Length -2; i>=0; i--)
         {
             suffix[i] = Math.Max(height[i],  suffix[i + 1]);
         }
         int sum = 0;
         for (int i = 0; i < height.Length; i++)
         {
             sum += Math.Min(prefix[i],suffix[i]) - height[i];
         }
         return sum;
     }
 }