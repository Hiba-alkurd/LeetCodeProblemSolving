//this is the solution on Leetcode
public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        
        if(nums.Length == 0) return 0;
        int currentIndex = 1;
        int currentDup = nums[0];
        int size = nums.Length;
            
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == currentDup)
            {
                size--;
            }
            else if (nums[i] == nums[i-1])
            {
                currentDup = nums[i];
                size--;
            }
            else
            {
                nums[currentIndex] = nums[i];
                currentIndex++;
            }
                
        }
        
        return size;
    }
}