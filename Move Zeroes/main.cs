namespace DefaultNamespace
{
    public class main
    {
        public void MoveZeroes(int[] nums)
        {
            int index = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index] = nums[i];
                    index++;
                }
            }

            for (; index < nums.Length; index++)
            {
                nums[index] = 0;
            }
        }
    }
}