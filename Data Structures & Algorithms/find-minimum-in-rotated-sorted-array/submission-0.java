class Solution {
    public int findMin(int[] nums)
    {
        int l = 0, r = nums.length -1;
        int min = nums[0];
        while(l <= r)
        {
            int mid = (l+r) /2;
            if(nums[mid] > nums[r])
            {
                min = Math.min(nums[mid], min);
                l = mid+ 1;
            }
            else
            {
                min = Math.min(nums[mid], min);
                r = mid -1;
            }
        }
        return min;
    }
}
