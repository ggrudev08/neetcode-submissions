public class Solution {
    public int LengthOfLongestSubstring(string s)
    {
        int end = 0;
        int start = 0;
        int maxLength = 0;

        HashSet<char> set = new HashSet<char>();
        
        while (end < s.Length)
        {
            
            while(set.Contains(s[end]))
            {
                set.Remove(s[start]);
                start++;
            }
            set.Add(s[end]);
            maxLength = (maxLength > set.Count) ? maxLength : set.Count;
            end++;
        }
        return maxLength;
    }
}
