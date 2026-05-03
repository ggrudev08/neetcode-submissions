class Solution {
    public int maxArea(int[] heights)
    {
        int l = 0, r = heights.length -1;
        int max = Math.min(heights[l], heights[r]) * (r-l);
        while(l < r)
        {
            if(heights[l] > heights[r])
                r--;
            else
                l++;
            int tmp = Math.min(heights[l], heights[r]) * (r-l);

            max = Math.max(tmp, max);
        }
        return max;
    }
}