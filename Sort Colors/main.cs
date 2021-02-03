namespace DefaultNamespace
{
    public class main
    {
        public void SortColors(int[] nums)
        {
            if(nums.Length == 0) return;
        
            int redCount = 0, whiteCount = 0, blueCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0) redCount++;
                if (nums[i] == 1) whiteCount++;
                if (nums[i] == 2) blueCount++;
            }

            int index = 0;
            for (; index < redCount; index++)
            {
                nums[index] = 0;
            }
            for (; index < whiteCount+redCount; index++)
            {
                nums[index] = 1;
            }
            for (; index < blueCount+whiteCount+redCount; index++)
            {
                nums[index] = 2;
            }
        }
    }
}