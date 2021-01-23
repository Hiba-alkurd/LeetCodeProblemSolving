namespace DefaultNamespace
{
    public class main
    {

        public bool CanJump(int[] nums)
       {
           if (nums.Length == 1) return true;
           for (int i = 0; i < nums.Length-1; )
           {
               if (nums[i] == 0) return false;
               var maxIndex = 1;
               for (var j = 1; j <= nums[i]; j++)
               {
                   if (j + i >= nums.Length - 1) return true;
                   if (nums[j + i] - (nums[i] - j) > (nums[maxIndex+i] - (nums[i] - maxIndex)))
                   {
                       maxIndex = j;
                   }
               }
               i = maxIndex + i;
           }
           return true;
       }
    }
}