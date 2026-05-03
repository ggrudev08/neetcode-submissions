public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int l = 0;
        int c = 0;
        HashSet<char> set = new HashSet<char>();
        for (int r = 0; r < s.Length; r++)
        {
            while (set.Contains(s[r]))
            {
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            c = Math.Max(c, set.Count);
        }
        return c;
    }
}
