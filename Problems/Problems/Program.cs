﻿using System;

namespace Problems
{
    class Program
    {
        public void MoveZeroes(int[] nums)
        {

            int Zerocount = 0;
            int moveIndex = 0;
            bool moved = true;
            int tem = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i]!=0)
                {
                    continue;
                }
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
        static void Main(string[] args)
        {
            int[] num = new[] {0,1,0,3,12};
            new Program().MoveZeroes(num);
            foreach (var VARIABLE in num)
            {
                Console.Write(VARIABLE+" ");
            } 
            
        }
    }
}