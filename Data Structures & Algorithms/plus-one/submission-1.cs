public class Solution {
    public int[] PlusOne(int[] digits)
    {
        int i = digits.Length -1;
        while (i >= 0 && digits[i] == 9)
        {
            digits[i--] = 0;
        }

        if (i < 0)
        {
            int[] newDigits = new int[digits.Length + 1];
            Array.Copy(digits, newDigits, digits.Length);
            newDigits[0] = 1;
            return newDigits;
        }

        digits[i]++;
        return digits;
    }
}