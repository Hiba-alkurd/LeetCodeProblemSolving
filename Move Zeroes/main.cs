namespace DefaultNamespace
{
    public class main
    {
        public void MoveZeroes(int[] nums)
        {
            int tem = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    for (int j = i; j < nums.Length; j++)
                    {
                        if (nums[j] != 0)
                        {
                            tem = nums[i];
                            nums[i] = nums[j];
                            nums[j] = tem;
                            break;
                        }
                    }
                }
                
            }
        }
    }
}