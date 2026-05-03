public class Solution {
     public int[] ProductExceptSelf(int[] nums)
 {
     int len = nums.Length;
     int[] prefix = new int[len];
     int[] suffix = new int[len];

     //Prefix (left -> right)
     prefix[0] = 1;
     for (int i = 1; i < len; i++)
     {
         prefix[i] = nums[i- 1] * prefix[i - 1];
     }

     //Suffix (right->left)
     suffix[len -1] = 1;
     for (int i = suffix.Length - 2; i >= 0; i--)
     {
         suffix[i] = suffix[i + 1] * nums[i + 1];
     }

     int[] output = new int[len];
     for(int i = 0; i < len; i++)
     {
         output[i] = prefix[i] * suffix[i];
     }    
     return output;
 }
}
