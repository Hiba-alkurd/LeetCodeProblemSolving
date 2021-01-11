using System;
using System.Collections.Generic;

namespace Problems
{
    
    public class RemoveDuplicatesp
    {
        public int RemoveDuplicates(int[] nums)
        {
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
        
       static void Main(string[] args)
        {
            RemoveDuplicatesp list = new RemoveDuplicatesp();
            int[] array = new[] {0,0,1,1,1,2,2,3,3,4};
            int size = list.RemoveDuplicates(array);
            Console.WriteLine("length" + size);
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " +array[i] + " ");
            }
                
        }
        

    }
}