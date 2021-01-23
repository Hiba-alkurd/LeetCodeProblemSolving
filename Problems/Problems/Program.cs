using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    class Program
    {

        public bool jump(int[] nums, int index)
        {
            if (index == nums.Length - 1) return true;
            if (index >= nums.Length) return false;

            bool found = false;
            for (int i = 0 ; i <= nums[index]; i++)
            {
                if (found) return found;
                found = found || jump(nums, index + i);
            }

            return found;
        }
        
       public bool CanJump1(int[] nums)
       {
           //return jump(nums, 0);
           if (nums.Length == 1) return true;
           var map = new Dictionary<int, int>();

           bool can = false;
           
           map.Add(0, nums[0]);
           for (int i = 1; i < nums.Length-1; i++)
           {
               UpdateMap(map);
               can = map.Any(x => x.Value >= 0);
               if (!can) return false;
               map.Add(i, nums[i]);
           }
           
           UpdateMap(map);
           
           return map.Any(x => x.Value >= 0);
       }

       private void UpdateMap(Dictionary<int, int> map)
       {
           for (int i = 0; i < map.Count; i++)
           {
               map[i] = map[i] - 1;
           }
       }
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

       static void Main(string[] args)
        {
            int[] tem = new[] {3,0,8,2,0,0,1};
            Console.WriteLine(new Program().CanJump(tem));
        }
    }
}