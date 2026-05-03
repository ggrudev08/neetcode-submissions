public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
{
    for (int i = 0; i < matrix.Length; i++)
    {
        if (matrix[i][matrix[i].Length - 1] < target) continue;
        int left = 0, right = matrix[i].Length - 1;

        while (left <= right)
        {
            int mid  = (left + right) / 2;
            if (matrix[i][mid] < target)
                left = mid + 1;
            else if (matrix[i][mid] > target)
                right = mid - 1;
            else
                return true;

        }

    }
    return false;
}
}
