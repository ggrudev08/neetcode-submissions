public class Solution {
    public int LongestConsecutive(int[] nums)
{
    HashSet<int> set = nums.ToHashSet();
    int longest = 0;

    foreach (var n in set)
    {
        if(!set.Contains(n -1))
        {
            int length = 0;
            while(set.Contains(n+length))
                length++;
            longest = (longest > length) ? longest : length;
        }
    }
    return longest; 

}
}
