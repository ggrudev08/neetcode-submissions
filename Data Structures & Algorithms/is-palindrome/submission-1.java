class Solution {
    public boolean isPalindrome(String s) 
    {
        s= s.toLowerCase();
        char[] word = s.toCharArray();
        int left = 0, right = word.length -1;

        while(left < right)
        {
           if(!Character.isLetterOrDigit(word[left]))
           { 
                left++;
                continue;
           }
           if(!Character.isLetterOrDigit(word[right]))
           { 
                right--;
                continue;
           }
         
           if(word[left] != word[right])return false;
           left++;
           right--;
        }
        return true;
    }
}